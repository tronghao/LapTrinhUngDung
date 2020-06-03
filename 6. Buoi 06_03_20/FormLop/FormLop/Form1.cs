using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLop
{
    public partial class Form1 : Form
    {
        tvkn_csdl csdl = new tvkn_csdl();
        public Form1()
        {
            InitializeComponent();
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaLop.ReadOnly = false;
            DataTable bangLop = new DataTable();
            String sql = "select ma_lop as 'Mã Lớp', ten_lop as 'Tên Lớp' from lop";
            bangLop = csdl.LayBang(sql);
            dgv.DataSource = bangLop;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maLop = txtMaLop.Text;
            String sql = "delete lop where ma_lop = '" + maLop + "'";
            if (csdl.CapnhatCSDL(sql))
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa không thành công");
            hienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maLop = txtMaLop.Text;
            String tenLop = txtTenLop.Text;
            String sql = "update lop set ten_lop = N'" + tenLop + "' where ma_lop = '" + maLop + "'";
            if (csdl.CapnhatCSDL(sql))
                MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật không thành công");
            hienThiDuLieu();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaLop.Text = dgv.Rows[index].Cells[0].Value.ToString();
            txtTenLop.Text = dgv.Rows[index].Cells[1].Value.ToString();
            txtMaLop.ReadOnly = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String maLop = txtMaLop.Text;
            String tenLop = txtTenLop.Text;
            String sql = "insert into lop values('" + maLop + "', N'" + tenLop + "')";
            if (csdl.CapnhatCSDL(sql))
                MessageBox.Show("Lưu thành công");
            else MessageBox.Show("Lưu không thành công");
            hienThiDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }
    }
}
