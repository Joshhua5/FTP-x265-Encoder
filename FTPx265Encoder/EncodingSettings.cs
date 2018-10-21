﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPx265Encoder
{
    public partial class EncodingSettings : Form
    {
        public EncodingSettings()
        {
            InitializeComponent();
            cbPresets.SelectedIndex = 4;
        }

        public string Preset
        {
            get
            {
                return cbPresets.SelectedItem.ToString();
            }
        }

        private void EncodingSettings_Load(object sender, EventArgs e)
        {
        }

        private void cbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
