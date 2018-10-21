using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPx265Encoder
{
    public class Connection
    {
        public string address;
        public NetworkCredential account;

        public void DownloadFile(string path, string name)
        {
            string ftpfullpath = address + path;
            Uri p = new Uri(ftpfullpath);
            Console.WriteLine("Downloading file " + p.ToString());
            using (WebClient request = new WebClient())
            {
                request.Credentials = account;
                request.DownloadFile(p, name);
            } 
        }

        public void DeleteFile(string path)
        {

            Uri p = new Uri(address + path);
            FtpWebRequest dirRequest = (FtpWebRequest)WebRequest.Create(p);

            dirRequest.Method = WebRequestMethods.Ftp.DeleteFile;
            dirRequest.Credentials = account;

            using (FtpWebResponse response = (FtpWebResponse)dirRequest.GetResponse()) { }
            Console.WriteLine("Deleted file " + p.ToString());
        }

        public void UploadFile(string path, string name)
        {
            string ftpfullpath = address + path;
            Uri p = new Uri(ftpfullpath);

            using (WebClient request = new WebClient())
            {
                request.Credentials = account;
                request.UploadFile(p, name);
            }

            Console.WriteLine("Uploaded file " + p.ToString());
        }

        public void GetVideoList(ref List<Video> videos, ref List<string> formats, TreeNode Node)
        {
            foreach (TreeNode fileNode in Node.Nodes)
            {
                if (fileNode.Nodes.Count != 0)
                {
                    // This is a folder that needs to be checked
                    GetVideoList(ref videos, ref formats, fileNode); 
                }
                else // Else this is a file to be checked
                {
                    string file = fileNode.Text;
                    if (file.Length == 0)
                        continue;
                    string format = file.Substring(file.LastIndexOf('.'));
                    foreach (string check in formats)
                    {
                        if (format.Contains(check))
                        {
                            Video video = new Video();
                            video.Name = file;
                            video.FullPath = fileNode.FullPath;
                            video.Format = format;
                            videos.Add(video);
                        }
                    }
                }
            }
        }

        private List<string> GetDirectoryDetails(string path)
        {
            try
            {
                List<string> directory = new List<string>();

                FtpWebRequest dirRequest = (FtpWebRequest)WebRequest.Create(new Uri(address + path));
                dirRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                dirRequest.Credentials = account;

                using (FtpWebResponse response = (FtpWebResponse)dirRequest.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        while (!reader.EndOfStream)
                            directory.Add(reader.ReadLine());
                        Console.WriteLine("Directory List Complete {0}", path);
                    }
                }
                return directory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
        }

        public List<Tuple<bool, string>> GetDirectory(string path)
        {
            try
            {
                List<Tuple<bool, string>> directory = new List<Tuple<bool, string>>();
                List<string> details = GetDirectoryDetails(path);

                FtpWebRequest dirRequest = (FtpWebRequest)WebRequest.Create(new Uri(address + path));

                dirRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                dirRequest.Credentials = account;

                using (FtpWebResponse response = (FtpWebResponse)dirRequest.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        int item = 0;
                        while (!reader.EndOfStream)
                            directory.Add(new Tuple<bool, string>(details[item++].StartsWith("d"), reader.ReadLine()));


                        Console.WriteLine("Directory List Complete {0}", path);
                    }
                }
                return directory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Tuple<bool, string>>();
            }
        }
    }
}
