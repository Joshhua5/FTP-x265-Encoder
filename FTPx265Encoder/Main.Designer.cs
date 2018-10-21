namespace FTPx265Encoder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvDir = new System.Windows.Forms.TreeView();
            this.btnStart = new System.Windows.Forms.Button();
            this.clbDownloads = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbUpload = new System.Windows.Forms.ProgressBar();
            this.pbEncode = new System.Windows.Forms.ProgressBar();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.backEncoder = new System.ComponentModel.BackgroundWorker();
            this.ffmpegProcess = new System.Diagnostics.Process();
            this.ffprobeProcess = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDir
            // 
            this.tvDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDir.Location = new System.Drawing.Point(3, 33);
            this.tvDir.Name = "tvDir";
            this.tvDir.Size = new System.Drawing.Size(1003, 232);
            this.tvDir.TabIndex = 0;
            this.tvDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDir_BeforeExpand);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(904, 460);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // clbDownloads
            // 
            this.clbDownloads.FormattingEnabled = true;
            this.clbDownloads.Location = new System.Drawing.Point(6, 288);
            this.clbDownloads.Name = "clbDownloads";
            this.clbDownloads.Size = new System.Drawing.Size(422, 225);
            this.clbDownloads.TabIndex = 2;
            this.clbDownloads.MouseHover += new System.EventHandler(this.clbDownloads_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "FTP Browser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detected Videos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumeSessionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resumeSessionToolStripMenuItem
            // 
            this.resumeSessionToolStripMenuItem.Name = "resumeSessionToolStripMenuItem";
            this.resumeSessionToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.resumeSessionToolStripMenuItem.Text = "Resume Session";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.encodingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.encodingToolStripMenuItem.Text = "Encoding";
            this.encodingToolStripMenuItem.Click += new System.EventHandler(this.encodingToolStripMenuItem_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControl.Controls.Add(this.btnScan);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.pbUpload);
            this.pnlControl.Controls.Add(this.pbEncode);
            this.pnlControl.Controls.Add(this.pbDownload);
            this.pnlControl.Controls.Add(this.btnStart);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.tvDir);
            this.pnlControl.Controls.Add(this.clbDownloads);
            this.pnlControl.Location = new System.Drawing.Point(12, 128);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1028, 532);
            this.pnlControl.TabIndex = 8;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(905, 431);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(101, 23);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Upload";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encode";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Download";
            // 
            // pbUpload
            // 
            this.pbUpload.Location = new System.Drawing.Point(509, 490);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(389, 23);
            this.pbUpload.TabIndex = 7;
            // 
            // pbEncode
            // 
            this.pbEncode.Location = new System.Drawing.Point(509, 460);
            this.pbEncode.Name = "pbEncode";
            this.pbEncode.Size = new System.Drawing.Size(389, 23);
            this.pbEncode.TabIndex = 6;
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(509, 430);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(389, 23);
            this.pbDownload.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(676, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 14);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 22);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "ftp://localhost";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(353, 14);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "test";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(549, 11);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "test";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 16);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.lblAddress);
            this.pnlLogin.Controls.Add(this.btnConnect);
            this.pnlLogin.Controls.Add(this.txtAddress);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Location = new System.Drawing.Point(12, 65);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(781, 45);
            this.pnlLogin.TabIndex = 10;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(474, 13);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(309, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User";
            // 
            // backEncoder
            // 
            this.backEncoder.WorkerReportsProgress = true;
            this.backEncoder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backEncoder_DoWork);
            this.backEncoder.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backEncoder_ProgressChanged);
            this.backEncoder.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backEncoder_RunWorkerCompleted);
            // 
            // ffmpegProcess
            // 
            this.ffmpegProcess.StartInfo.Domain = "";
            this.ffmpegProcess.StartInfo.LoadUserProfile = false;
            this.ffmpegProcess.StartInfo.Password = null;
            this.ffmpegProcess.StartInfo.StandardErrorEncoding = null;
            this.ffmpegProcess.StartInfo.StandardOutputEncoding = null;
            this.ffmpegProcess.StartInfo.UserName = "";
            this.ffmpegProcess.SynchronizingObject = this;
            // 
            // ffprobeProcess
            // 
            this.ffprobeProcess.StartInfo.Domain = "";
            this.ffprobeProcess.StartInfo.LoadUserProfile = false;
            this.ffprobeProcess.StartInfo.Password = null;
            this.ffprobeProcess.StartInfo.StandardErrorEncoding = null;
            this.ffprobeProcess.StartInfo.StandardOutputEncoding = null;
            this.ffprobeProcess.StartInfo.UserName = "";
            this.ffprobeProcess.SynchronizingObject = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 672);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "FTP x265 Encoder";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDir;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckedListBox clbDownloads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeSessionToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbUpload;
        private System.Windows.Forms.ProgressBar pbEncode;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.ComponentModel.BackgroundWorker backEncoder;
        private System.Windows.Forms.Button btnScan;
        private System.Diagnostics.Process ffmpegProcess;
        private System.Diagnostics.Process ffprobeProcess;
    }
}