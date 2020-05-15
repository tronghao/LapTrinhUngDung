using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_13_05_20
{
    public partial class Form1 : Form
    {
        KN_CSDL csdl = new KN_CSDL();
        public Form1()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            String sql = "SELECT maSinhVien as 'Mã Sinh Viên', tenSinhVien as 'Tên Sinh Viên' FROM sinhvien";
            DataTable bangSinhVien = new DataTable();
            bangSinhVien = csdl.LayBang(sql);
            dgvSinhVien.DataSource = bangSinhVien;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
