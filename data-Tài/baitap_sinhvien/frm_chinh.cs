using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_sinhvien
{
    public partial class frm_chinh : Form
    {
        public frm_chinh()
        {
            InitializeComponent();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Lop frmlop = new frm_Lop();
            frmlop.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SV frmsv = new frm_SV();
            frmsv.ShowDialog();
        }
    }
}
