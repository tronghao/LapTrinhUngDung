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
    public partial class frm_cbb : Form
    {
        public frm_cbb()
        {
            InitializeComponent();
            ColumnHeader columnHeader1 = new ColumnHeader();

            ColumnHeader columnHeader2 = new ColumnHeader();

            ColumnHeader columnHeader3 = new ColumnHeader();

            columnHeader1.Text = "Tên";

            columnHeader2.Text = "Địa chỉ";

            columnHeader3.Text = "Sđt";

            listView1.Columns.Add(columnHeader1);

            listView1.Columns.Add(columnHeader2);

            listView1.Columns.Add(columnHeader3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Items[comboBox1.SelectedIndex].ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
