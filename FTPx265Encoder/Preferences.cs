using System;
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
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
            for (int x = 0; x < clbFormats.Items.Count; ++x)
                clbFormats.SetItemChecked(x, true);
        }

        public List<string> Formats
        {
            get
            {
                lock (clbFormats)
                {
                    List<string> fmts = new List<string>();
                    foreach (var item in clbFormats.CheckedItems)
                        fmts.Add(item.ToString());
                    return fmts;
                }
            }
        }

        public bool DeleteOriginals
        {
            get
            {
                return chbDelOriginals.Checked;
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {

        }
    }
}
