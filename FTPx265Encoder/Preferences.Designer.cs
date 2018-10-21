namespace FTPx265Encoder
{
    partial class Preferences
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
            this.clbFormats = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbDelOriginals = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // clbFormats
            // 
            this.clbFormats.CheckOnClick = true;
            this.clbFormats.FormattingEnabled = true;
            this.clbFormats.Items.AddRange(new object[] {
            ".avi",
            ".mkv",
            ".mp4"});
            this.clbFormats.Location = new System.Drawing.Point(12, 63);
            this.clbFormats.Name = "clbFormats";
            this.clbFormats.Size = new System.Drawing.Size(156, 157);
            this.clbFormats.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scanned Video Formats";
            // 
            // chbDelOriginals
            // 
            this.chbDelOriginals.AutoSize = true;
            this.chbDelOriginals.Location = new System.Drawing.Point(15, 245);
            this.chbDelOriginals.Name = "chbDelOriginals";
            this.chbDelOriginals.Size = new System.Drawing.Size(131, 21);
            this.chbDelOriginals.TabIndex = 8;
            this.chbDelOriginals.Text = "Delete Originals";
            this.chbDelOriginals.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 488);
            this.Controls.Add(this.chbDelOriginals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbFormats);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbFormats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbDelOriginals;
    }
}