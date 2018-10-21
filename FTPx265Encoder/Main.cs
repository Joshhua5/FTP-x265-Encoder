using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace FTPx265Encoder
{
    public partial class Main : Form
    {

        private List<Video> video_list = new List<Video>();
        private Preferences preference_window = new Preferences();
        private EncodingSettings encoder_window = new EncodingSettings();

        private TreeNode scan_node = null;
        private Connection conn = null;
        private TreeNode rootNode;

        private AutoResetEvent mpeg_reset_handle = new AutoResetEvent(false);
        private AutoResetEvent probe_reset_handle = new AutoResetEvent(false);
        private Video probe_video;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Download the first directory 
            pnlControl.Enabled = false;
            rootNode = tvDir.Nodes.Add("/");
            rootNode.Nodes.Add("");

            // Setup Processes 
            ffmpegProcess.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            ffmpegProcess.StartInfo.FileName = @Environment.CurrentDirectory + "\\ffmpeg\\ffmpeg.exe";
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.RedirectStandardError = true;
            ffmpegProcess.ErrorDataReceived += (sendr, str) =>
            {
                if (str.Data == null)
                    mpeg_reset_handle.Set();
                else if (str.Data.Contains("frame"))
                {  // We have a progress message
                    Console.WriteLine(str.Data);

                }
            };

            ffprobeProcess.StartInfo.FileName = @Environment.CurrentDirectory + "\\ffmpeg\\ffprobe.exe";
            ffprobeProcess.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            ffprobeProcess.StartInfo.RedirectStandardError = true;
            ffprobeProcess.StartInfo.UseShellExecute = false;
            ffprobeProcess.ErrorDataReceived += (sendr, str) =>
            {
                if (str.Data == null)
                    probe_reset_handle.Set();
                else
                    probe_video.Probe += str.Data + "\n";
            };
        }

        // Extracts the name from all the information returned
        // Once this is complete we can half the count of listing calls to the
        // FTP server
        private string ExtractName(string str)
        {
            //"drwxr-xr-x 1 ftp ftp              0 Apr 12  2016 apache-maven-2.2.1";
            //int name_seek = 0;
            //for(int x = 0; x < 3; ++x)
            //    str.IndexOf(' ', name_seek);
            //str.IndexOfAny()
            return "";
        }

        // Returns true if encoding is required
        private bool ProbeVideo(Video video)
        {
            try
            {
                ffprobeProcess.Refresh();
                ffprobeProcess.StartInfo.Arguments = "-hide_banner -i \"" + video.Name + "\"";
                probe_video = video;
                video.Probe = "";
                ffprobeProcess.Start();
                ffprobeProcess.BeginErrorReadLine();
                probe_reset_handle.WaitOne();
                ffprobeProcess.WaitForExit();
                ffprobeProcess.CancelErrorRead();
                probe_reset_handle.Reset();
                 
                bool isHEVC = false; 
                string line;
                video.Duration = 0;
                using (StringReader reader = new StringReader(video.Probe))
                {
                    while((line = reader.ReadLine()) != null)
                    {
                        line = line.ToUpper();
                        if (line.Contains("HEVC"))
                            isHEVC = true;
                        if (video.Duration == 0 && line.Contains("DURATION"))
                        {
                            try {
                                string sub = line.Substring(line.IndexOf(':') + 1, 9);
                                video.Duration = Convert.ToInt32(TimeSpan.Parse(sub).TotalSeconds); 
                            }catch(Exception ex)
                            {
                                Console.WriteLine("Unable to get duration: " + ex.Message);
                            }
                        }
                    }
                }

                return isHEVC == false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }
         
        private void SaveProgress()
        {

        }

        private void EncodeVideo(Video video)
        {
            video.NewName = video.Name + "[HEVC].mkv";
            video.NewFullPath = video.FullPath + "[HEVC].mkv";

            if (File.Exists(video.NewFullPath))
                File.Delete(video.NewFullPath);

            ffmpegProcess.StartInfo.Arguments =
                " -hide_banner " +
                " -ss 0 " +
                " -i \"" + video.Name + "\" " +
                " -map_metadata 0 " +
                " -map_chapters 0 " +
                " -c:v libx265 -preset " + encoder_window.Preset +
                " -x265-params " +
                " crf=28" +
                ":qcomp=0.8" +
                ":aq-mode=1" +
                ":aq_strength=1.0" +
                ":qg-size=16" +
                ":psy-rd=0.7" +
                ":psy-rdoq=5.0" +
                ":rdoq-level=1" +
                ":merange=44" +
                " -c:a copy " +
                " -c:s copy " +
                " \"" + video.NewName + "\"";

            ffmpegProcess.Refresh();
             
            if (ffmpegProcess.Start())
            {
                ffmpegProcess.BeginErrorReadLine();
                mpeg_reset_handle.WaitOne();
                ffmpegProcess.WaitForExit();
                ffmpegProcess.CancelErrorRead();
            }
            else
                Console.WriteLine("Unable to start FFMPEG");
            mpeg_reset_handle.Reset();
        }

        private void FullExpand(TreeNode node)
        {
            // Download the directory for this folder
            node.Nodes.Clear();
            List<Tuple<bool, string>> root = conn.GetDirectory(node.FullPath);
            foreach (var dir in root)
            {
                TreeNode subNode = node.Nodes.Add(dir.Item2 + ((dir.Item1) ? "/" : ""));
                if (dir.Item1)
                    FullExpand(subNode);
            }
        }

        private void tvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Download the directory for this folder
            e.Node.Nodes.Clear();
            Console.WriteLine(e.Node.FullPath);
            List<Tuple<bool, string>> root = conn.GetDirectory(e.Node.FullPath);
            foreach (var dir in root)
            {
                TreeNode node = e.Node.Nodes.Add(dir.Item2 + ((dir.Item1) ? "/" : ""));
                if (dir.Item1)
                    node.Nodes.Add("");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            scan_node = tvDir.SelectedNode;
            if (scan_node != null)
            {
                btnStart.Enabled = false;
                btnStart.Text = "Encoding";
                FullExpand(scan_node);
                backEncoder.RunWorkerAsync();
            }
            else
                MessageBox.Show("Please select a folder to scan");
            // Get a list of all videos to be encoded with their full path
        }

        private void clbDownloads_MouseHover(object sender, EventArgs e)
        {
            int ttIndex = clbDownloads.IndexFromPoint(clbDownloads.PointToClient(MousePosition));
            if (ttIndex > -1)
            {
                Video video = clbDownloads.Items[ttIndex] as Video;
                if (video.tip == null)
                    video.tip = new ToolTip();
                video.tip.ToolTipTitle = video.Name;
                video.tip.SetToolTip(clbDownloads, video.FullPath);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Login to FTP Server 
            conn = new Connection();
            conn.account = new NetworkCredential(txtUser.Text, txtPass.Text);
            conn.address = txtAddress.Text;

            // Test Connection


            // Enable Control
            pnlControl.Enabled = true;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preference_window.Show();
        }

        private void encodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoder_window.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backEncoder_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> formats = preference_window.Formats;
            video_list.Clear();
            conn.GetVideoList(ref video_list, ref formats, scan_node);
            backEncoder.ReportProgress(0);

            Invoke((MethodInvoker)delegate
            {
                clbDownloads.Items.Clear();
                foreach (Video video in video_list)
                {
                    int index = clbDownloads.Items.Add(video);
                    clbDownloads.SetItemChecked(index, (video.Status == Status.Finished));
                }
            });

            foreach (Video video in video_list)
            {
                try
                {
                    try
                    {

                        // Update log of videos

                        try
                        {
                            string encoded = JsonConvert.SerializeObject(video_list);
                            File.WriteAllText("progress.json", encoded);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unable to log progress " + ex.Message);
                        }

                        // Download 
                        video.Status = Status.Downloading;
                        backEncoder.ReportProgress(25);
                        conn.DownloadFile(video.FullPath, video.Name);

                        // Probe Format
                        if (ProbeVideo(video))
                        {
                            // Encode  
                            video.Status = Status.Encoding;
                            backEncoder.ReportProgress(50);
                            EncodeVideo(video);

                            

                            long newSize = 0;
                            long oldSize = 0;
                            if (File.Exists(video.NewUri.AbsolutePath))
                                newSize = new FileInfo(video.NewUri.AbsolutePath).Length;
                            if (File.Exists(video.OriginalUri.AbsolutePath))
                                oldSize = new FileInfo(video.OriginalUri.AbsolutePath).Length;

                            if (newSize > oldSize)
                            {
                                video.Status = Status.Bloated;
                            }
                            else {
                                // Upload 
                                video.Status = Status.Uploading;
                                backEncoder.ReportProgress(75);
                                conn.UploadFile(video.NewFullPath, video.NewName);
                                video.Status = Status.Finished;

                                // Delete Original
                                if (preference_window.DeleteOriginals)
                                    conn.DeleteFile(video.FullPath);
                            } 
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Source);
                        Console.WriteLine(exception.StackTrace);
                        Console.WriteLine(exception.Message);

                        video.Status = Status.Failed;
                        video.Error = exception;
                        Console.WriteLine("Do you have read/write/delete permissions to this folder?");
                    }
                    try
                    {
                        if (File.Exists(video.Name))
                            File.Delete(video.Name);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    try
                    {
                        if (File.Exists(video.NewName))
                            File.Delete(video.NewName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine("Encode Thread Finished");
        }

        private void backEncoder_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            clbDownloads.Items.Clear();
            foreach (Video video in video_list)
            {
                int index = clbDownloads.Items.Add(video);
                clbDownloads.SetItemChecked(index, (video.Status == Status.Finished));
            }
            pbEncode.Value = e.ProgressPercentage;
        }

        private void backEncoder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
            btnStart.Text = "Start";
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            scan_node = tvDir.SelectedNode;
            if (scan_node != null)
            {
                FullExpand(scan_node);
                video_list.Clear();
                List<string> formats = preference_window.Formats;
                conn.GetVideoList(ref video_list, ref formats, scan_node);
                clbDownloads.Items.Clear();
                foreach (Video video in video_list)
                {
                    int index = clbDownloads.Items.Add(video);
                    clbDownloads.SetItemChecked(index, (video.Status == Status.Finished));
                }
            }
        }
    }
}
