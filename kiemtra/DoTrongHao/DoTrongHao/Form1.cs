using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoTrongHao
{
    public partial class Form1 : Form
    {
        KNCSDL connect = new KNCSDL();
        public Form1()
        {
            InitializeComponent();
            hienThiDuLieu();
        }


        public void hienThiDuLieu()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMHD.Text = "";
            txtSoTien.Text = "";

            txtMHD.ReadOnly = false;
            DataTable bangLop = new DataTable();
            String sql = "select MaHD as 'Mã Hóa Đơn', MaNV as 'Mã NV', MaKH as 'Mã KH', NgayBan as 'Ngày Bán', SoTien as 'Số Tiền' from hoadon";
            bangLop = connect.LayBang(sql);
            dgv.DataSource = bangLop;

            DataTable bangnhanvien = new DataTable();
            sql = "select * from nhanvien";
            bangnhanvien = connect.LayBang(sql);

            cbMaNV.DataSource = bangnhanvien;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";

            DataTable bangkhachhang = new DataTable();
            sql = "select * from khachhang";
            bangkhachhang = connect.LayBang(sql);

            cbMaKH.DataSource = bangkhachhang;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool choPhepLuu = true;
            String maHD = txtMHD.Text.Trim();
            if(maHD == "")
            {
                choPhepLuu = false;
                MessageBox.Show("Chưa nhập mã hóa đơn");
            }
            String maKH = cbMaKH.SelectedValue.ToString().Trim();
            String maNV = cbMaNV.SelectedValue.ToString().Trim();
            String ngayBan = dtp.Value.ToString("dd/MM/yyyy").Trim();
            long soTien = 0;
            try
            {
                soTien = long.Parse(txtSoTien.Text.Trim());
                if(soTien < 0)
                {
                    choPhepLuu = false;
                    MessageBox.Show("Số tiền nhập không hợp lệ");
                }
            }
            catch(Exception ex)
            {
                choPhepLuu = false;
                MessageBox.Show("Số tiền nhập không hợp lệ");
            }

            if(choPhepLuu)
            {
                String sql = "insert into hoadon values('" + maHD + "', '" + maNV + "', '" + maKH + "', '" + ngayBan + "', '" + soTien + "')";
                if (connect.CapnhatCSDL(sql))
                    MessageBox.Show("Lưu thành công");
                else MessageBox.Show("Lưu không thành công");
                hienThiDuLieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool choPhepLuu = true;
            String maHD = txtMHD.Text.Trim();
            String maKH = cbMaKH.SelectedValue.ToString().Trim();
            String maNV = cbMaNV.SelectedValue.ToString().Trim();
            String ngayBan = dtp.Value.ToString("dd/MM/yyyy").Trim();

            long soTien = 0;
            try
            {
                soTien = long.Parse(txtSoTien.Text.Trim());
                if (soTien < 0)
                {
                    choPhepLuu = false;
                    MessageBox.Show("Số tiền nhập không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                choPhepLuu = false;
                MessageBox.Show("Số tiền nhập không hợp lệ");
            }

            if (choPhepLuu)
            {
                String sql = "update hoadon set MaNV = '" + maNV + "', MaKH = '" + maKH + "', NgayBan = '" + ngayBan + "', SoTien = '" + soTien + "' where MaHD = '" + maHD + "'";
                if (connect.CapnhatCSDL(sql))
                    MessageBox.Show("Lưu thành công");
                else MessageBox.Show("Lưu không thành công");
                hienThiDuLieu();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index != -1)
            {
              
                txtMHD.Text = dgv.Rows[index].Cells[0].Value.ToString().Trim();
                string giaTriMaNV = dgv.Rows[index].Cells[1].Value.ToString();
                string giaTriMaKH = dgv.Rows[index].Cells[2].Value.ToString();
                String giaTriNgayBan = dgv.Rows[index].Cells[3].Value.ToString().Trim();

                int day =  Int32.Parse( (giaTriNgayBan[0].ToString() + giaTriNgayBan[1].ToString()).ToString() ) ;
                int month = Int32.Parse((giaTriNgayBan[3].ToString() + giaTriNgayBan[4].ToString()).ToString());
                int year = Int32.Parse((giaTriNgayBan[6].ToString() + giaTriNgayBan[7].ToString() + giaTriNgayBan[8].ToString() + giaTriNgayBan[9].ToString()).ToString());
                DateTime ngayBan = new DateTime(year, month, day);
                dtp.Value = ngayBan;
    
                txtSoTien.Text = dgv.Rows[index].Cells[4].Value.ToString().Trim();
                //cbTenLop.ValueMember = dgv.Rows[index].Cells[2].Value.ToString();
                cbMaKH.SelectedIndex = cbMaKH.FindStringExact(giaTriMaKH);
                cbMaNV.SelectedIndex = cbMaNV.FindStringExact(giaTriMaNV);
                txtMHD.ReadOnly = true;

                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maLop = txtMHD.Text;
            String sql = "delete hoadon where MaHD = '" + maLop + "'";
            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa không thành công");
            hienThiDuLieu();

        }
    }
}
