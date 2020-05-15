using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1
{
    public partial class listbox_combox : Form
    {
        public listbox_combox()
        {
            InitializeComponent();
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (ltb.Items.IndexOf(txt_add.Text.Trim()) >= 0)
            {
                ltb.SelectedItem = txt_add.Text.Trim();
            }
            else if (txt_add.Text.Length > 0)
                ltb.Items.Add(txt_add.Text);
        }

        private void ltb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb.SelectedIndex >= 0)
            {
                ltb.Items.RemoveAt(ltb.SelectedIndex);
            }
        }
    }
}
