using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien frm_sv = new SinhVien();
            frm_sv.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc frm_mh = new MonHoc();
            frm_mh.ShowDialog();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem frm_diem = new Diem();
            frm_diem.ShowDialog();
        }
    }
}
