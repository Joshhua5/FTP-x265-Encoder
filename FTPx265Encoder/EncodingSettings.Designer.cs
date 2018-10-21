namespace FTPx265Encoder
{
    partial class EncodingSettings
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
            this.cbPresets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCRF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQGSIZE = new System.Windows.Forms.TextBox();
            this.txtRDOQLVL = new System.Windows.Forms.TextBox();
            this.txtSQSTR = new System.Windows.Forms.TextBox();
            this.txtAQMODE = new System.Windows.Forms.TextBox();
            this.txtQCOMP = new System.Windows.Forms.TextBox();
            this.txtPSYRD = new System.Windows.Forms.TextBox();
            this.txtMERANGE = new System.Windows.Forms.TextBox();
            this.txtPSYRDOQ = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPresets
            // 
            this.cbPresets.FormattingEnabled = true;
            this.cbPresets.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "slower",
            "veryslow",
            "placebo"});
            this.cbPresets.Location = new System.Drawing.Point(163, 9);
            this.cbPresets.Name = "cbPresets";
            this.cbPresets.Size = new System.Drawing.Size(212, 24);
            this.cbPresets.TabIndex = 0;
            this.cbPresets.SelectedIndexChanged += new System.EventHandler(this.cbPresets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encoding CPU Preset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "qcomp";
            // 
            // txtCRF
            // 
            this.txtCRF.Location = new System.Drawing.Point(164, 41);
            this.txtCRF.Name = "txtCRF";
            this.txtCRF.Size = new System.Drawing.Size(211, 22);
            this.txtCRF.TabIndex = 4;
            this.txtCRF.Text = "23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "qg-size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "aq_strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "merange";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "rdoq-level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "psy-rdoq";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "psy-rd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "aq-mode";
            // 
            // txtQGSIZE
            // 
            this.txtQGSIZE.Location = new System.Drawing.Point(164, 153);
            this.txtQGSIZE.Name = "txtQGSIZE";
            this.txtQGSIZE.Size = new System.Drawing.Size(211, 22);
            this.txtQGSIZE.TabIndex = 12;
            this.txtQGSIZE.Text = "16";
            // 
            // txtRDOQLVL
            // 
            this.txtRDOQLVL.Location = new System.Drawing.Point(163, 237);
            this.txtRDOQLVL.Name = "txtRDOQLVL";
            this.txtRDOQLVL.Size = new System.Drawing.Size(211, 22);
            this.txtRDOQLVL.TabIndex = 13;
            this.txtRDOQLVL.Text = "1";
            // 
            // txtSQSTR
            // 
            this.txtSQSTR.Location = new System.Drawing.Point(164, 125);
            this.txtSQSTR.Name = "txtSQSTR";
            this.txtSQSTR.Size = new System.Drawing.Size(211, 22);
            this.txtSQSTR.TabIndex = 14;
            this.txtSQSTR.Text = "1.0";
            // 
            // txtAQMODE
            // 
            this.txtAQMODE.Location = new System.Drawing.Point(164, 97);
            this.txtAQMODE.Name = "txtAQMODE";
            this.txtAQMODE.Size = new System.Drawing.Size(211, 22);
            this.txtAQMODE.TabIndex = 15;
            this.txtAQMODE.Text = "1";
            // 
            // txtQCOMP
            // 
            this.txtQCOMP.Location = new System.Drawing.Point(164, 69);
            this.txtQCOMP.Name = "txtQCOMP";
            this.txtQCOMP.Size = new System.Drawing.Size(211, 22);
            this.txtQCOMP.TabIndex = 16;
            this.txtQCOMP.Text = "0.8";
            // 
            // txtPSYRD
            // 
            this.txtPSYRD.Location = new System.Drawing.Point(164, 181);
            this.txtPSYRD.Name = "txtPSYRD";
            this.txtPSYRD.Size = new System.Drawing.Size(211, 22);
            this.txtPSYRD.TabIndex = 17;
            this.txtPSYRD.Text = "0.7";
            // 
            // txtMERANGE
            // 
            this.txtMERANGE.Location = new System.Drawing.Point(164, 265);
            this.txtMERANGE.Name = "txtMERANGE";
            this.txtMERANGE.Size = new System.Drawing.Size(211, 22);
            this.txtMERANGE.TabIndex = 18;
            this.txtMERANGE.Text = "44";
            // 
            // txtPSYRDOQ
            // 
            this.txtPSYRDOQ.Location = new System.Drawing.Point(164, 209);
            this.txtPSYRDOQ.Name = "txtPSYRDOQ";
            this.txtPSYRDOQ.Size = new System.Drawing.Size(211, 22);
            this.txtPSYRDOQ.TabIndex = 19;
            this.txtPSYRDOQ.Text = "5.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPSYRDOQ);
            this.panel1.Controls.Add(this.cbPresets);
            this.panel1.Controls.Add(this.txtMERANGE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPSYRD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtQCOMP);
            this.panel1.Controls.Add(this.txtCRF);
            this.panel1.Controls.Add(this.txtAQMODE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSQSTR);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRDOQLVL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtQGSIZE);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 306);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 175);
            this.panel2.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Video";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Audio (Copied)";
            // 
            // EncodingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 587);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EncodingSettings";
            this.Text = "EncodingSettings";
            this.Load += new System.EventHandler(this.EncodingSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPresets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCRF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQGSIZE;
        private System.Windows.Forms.TextBox txtRDOQLVL;
        private System.Windows.Forms.TextBox txtSQSTR;
        private System.Windows.Forms.TextBox txtAQMODE;
        private System.Windows.Forms.TextBox txtQCOMP;
        private System.Windows.Forms.TextBox txtPSYRD;
        private System.Windows.Forms.TextBox txtMERANGE;
        private System.Windows.Forms.TextBox txtPSYRDOQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}