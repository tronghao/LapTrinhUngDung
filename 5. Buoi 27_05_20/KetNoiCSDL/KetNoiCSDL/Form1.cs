using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiCSDL
{
    public partial class Form1 : Form
    {
        ThuVienKNCSDL conn = new ThuVienKNCSDL();
        public Form1()
        {
            InitializeComponent();
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            String sql = "Select MaSo as 'Mã Số', HoTen as 'Họ Tên', lop as 'Lớp' from sinhvien";
            DataTable sinhvien = new DataTable();
            sinhvien = conn.LayBang(sql);

            dgv.DataSource = sinhvien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            dgv.Rows.Clear();
        }
    }
}
