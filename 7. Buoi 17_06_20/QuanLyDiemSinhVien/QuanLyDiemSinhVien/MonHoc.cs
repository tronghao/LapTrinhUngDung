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
    public partial class MonHoc : Form
    {
        ThuVienKNCSDL connect = new ThuVienKNCSDL();
        public MonHoc()
        {
            InitializeComponent();
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtMaMH.ReadOnly = false;

            String sql = "select ma_mh as 'Mã Môn Học', ten_mh as 'Tên Môn Học' from monhoc";
            DataTable bangMH = new DataTable();
            bangMH = connect.LayBang(sql);
            dgvData.DataSource = bangMH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String maMH = txtMaMH.Text.Trim();
            String tenMH = txtTenMH.Text.Trim();

            String sql = "insert into monhoc values('" + maMH + "', N'" + tenMH + "')";

            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Thêm dữ liệu thành công");
            else MessageBox.Show("Thêm dữ liệu không thành công");

            hienThiDuLieu();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                txtMaMH.Text = dgvData.Rows[index].Cells[0].Value.ToString();
                txtTenMH.Text = dgvData.Rows[index].Cells[1].Value.ToString();
                txtMaMH.ReadOnly = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maMH = txtMaMH.Text.Trim();

            String sql = "delete monhoc where ma_mh ='" + maMH + "'";
            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Xóa dữ liệu thành công");
            else MessageBox.Show("Xóa dữ liệu không thành công");

            hienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maMH = txtMaMH.Text.Trim();
            String tenMH = txtTenMH.Text.Trim();

            String sql = "update monhoc set ten_mh='" + tenMH + "' where ma_mh='" + maMH + "'";

            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Cập nhật dữ liệu thành công");
            else MessageBox.Show("Cập nhật dữ liệu không thành công");

            hienThiDuLieu();
        }
    }
}
