using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_b2
{
    public partial class Form1 : Form
    {
        string gt = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_ten.Text.Trim(), "Thông báo!");
        }

        private void chb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_nam.Checked)
            {
                gt = "Nam";
                chb_nu.Checked = false;
            }
        }

        private void chb_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_nu.Checked)
            {
                gt = "Nữ";
                chb_nam.Checked = false;
            }

        }

        private void btn_ok2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gt, "Thông báo!");
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection ds;
            ds = checkedListBox1.CheckedItems;
            string dschon = "Đã chọn: ";
            foreach (object i in ds)
            {
                dschon += i.ToString() + "\n";
            }
            MessageBox.Show(dschon, "Thông báo!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            label1.Text = Text.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_phu p = new frm_phu();
            p.Show();
        }

        private void dtgv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = e.RowIndex;
                txt_1.Text = dtgv_1.Rows[n].Cells[0].Value.ToString();
                txt_2.Text = dtgv_1.Rows[n].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
