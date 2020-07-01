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
    public partial class SinhVien : Form
    {
        ThuVienKNCSDL connect = new ThuVienKNCSDL();
        public SinhVien()
        {
            InitializeComponent();
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtMaSV.ReadOnly = false;

            //hien thi len datagridview
            String sql = "select mssv as 'Mã SV', ho_ten as 'Tên SV' from sinhvien";
            DataTable bangSV = new DataTable();
            bangSV = connect.LayBang(sql);
            dgvData.DataSource = bangSV;
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
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text.Trim();
            String tenSV = txtTenSV.Text.Trim();

            String sql = "insert into sinhvien values('"+ maSV +"', N'"+ tenSV +"')";

            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Thêm dữ liệu thành công");
            else MessageBox.Show("Thêm dữ liệu không thành công");

            hienThiDuLieu();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index != -1)
            {
                txtMaSV.Text = dgvData.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dgvData.Rows[index].Cells[1].Value.ToString();
                txtMaSV.ReadOnly = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text.Trim();

            String sql = "delete sinhvien where mssv ='"+ maSV +"'";
            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Xóa dữ liệu thành công");
            else MessageBox.Show("Xóa dữ liệu không thành công");

            hienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text.Trim();
            String tenSV = txtTenSV.Text.Trim();

            String sql = "update sinhvien set ho_ten='"+ tenSV +"' where mssv='"+ maSV +"'";

            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Cập nhật dữ liệu thành công");
            else MessageBox.Show("Cập nhật dữ liệu không thành công");

            hienThiDuLieu();
        }
    }
}
