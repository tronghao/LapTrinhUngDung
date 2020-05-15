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
    public partial class Form1 : Form
    {
        HCN h;

        public Form1()
        {
            InitializeComponent();
            h = new HCN();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt_cd.Text.Trim());
                int b = int.Parse(txt_cr.Text.Trim());
                h.CD = a;
                h.CR = b;
                lb_KQ.Text = h.tinhchuvi().ToString();
            }
            catch
            {
                MessageBox.Show("Sai Roi", "Thong Bao!");
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Di Nhe", "Thong báo");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
