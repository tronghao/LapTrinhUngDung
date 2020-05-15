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
    public partial class frm_phu : Form
    {
        public frm_phu()
        {
            InitializeComponent();
        }

        private void dtgv_acc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = e.RowIndex;
                txt_name.Text = dtgv_acc.Rows[n].Cells[0].Value.ToString();
                txt_phone.Text = dtgv_acc.Rows[n].Cells[1].Value.ToString();
            }
            catch
            {

            }
            
        }
    }
}
