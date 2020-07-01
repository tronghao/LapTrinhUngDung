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
    public partial class Diem : Form
    {
        ThuVienKNCSDL connect = new ThuVienKNCSDL();
        public Diem()
        {
            InitializeComponent();
            hienThiDuLieu();
        }

        public void hienThiDuLieu()
        {
            cbSV.Enabled = true;
            cbMH.Enabled = true;
            txtDL1.Text = "";
            txtDL2.Text = ""; 
            txtDKT.Text = "";

            String sql = "select ho_ten as 'Họ Tên', ten_mh as 'Tên Môn Học', diem_lan_1 as 'Điểm lần 1', diem_lan_2 as 'Điểm Lần 2', diem_ket_thuc as 'Điểm Kết Thúc' from sinhvien, monhoc, diem where sinhvien.mssv = diem.mssv and monhoc.ma_mh = diem.ma_mh ";
            DataTable bangDuLieu = new DataTable();
            bangDuLieu = connect.LayBang(sql);
            dgvData.DataSource = bangDuLieu;


            //hiển thị cbSV
            DataTable bangsinhvien = new DataTable();
            sql = "select * from sinhvien";
            bangsinhvien = connect.LayBang(sql);

            cbSV.DataSource = bangsinhvien;
            cbSV.DisplayMember = "ho_ten";
            cbSV.ValueMember = "mssv";


            //hiển thị cbMH
            DataTable bangMonHoc = new DataTable();
            sql = "select * from monhoc";
            bangMonHoc = connect.LayBang(sql);

            cbMH.DataSource = bangMonHoc;
            cbMH.DisplayMember = "ten_mh";
            cbMH.ValueMember = "ma_mh";
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
            try
            {
                String maSV = cbSV.SelectedValue.ToString();
                String maMH = cbMH.SelectedValue.ToString();
                float diemLan1 = float.Parse( txtDL1.Text.ToString() );
                float diemLan2 = float.Parse(txtDL2.Text.ToString());
                float diemLanKetThuc = float.Parse(txtDKT.Text.ToString());

                String sql = "insert into diem values('"+ maSV +"', '"+ maMH +"', "+ diemLan1 +" , "+ diemLan2 +" , "+ diemLanKetThuc +")";

                if (connect.CapnhatCSDL(sql))
                    MessageBox.Show("Thêm dữ liệu thành công");
                else MessageBox.Show("Thêm dữ liệu không thành công");

                hienThiDuLieu();
            } catch(Exception e1)
            {
                MessageBox.Show("Thêm dữ liệu không thành công");
            }
           
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                String tenSV = dgvData.Rows[index].Cells[0].Value.ToString();
                cbSV.SelectedIndex = cbSV.FindStringExact(tenSV);

                String tenMH = dgvData.Rows[index].Cells[1].Value.ToString();
                cbSV.SelectedIndex = cbSV.FindStringExact(tenMH);

                txtDL1.Text = dgvData.Rows[index].Cells[2].Value.ToString();
                txtDL2.Text = dgvData.Rows[index].Cells[3].Value.ToString();
                txtDKT.Text = dgvData.Rows[index].Cells[4].Value.ToString();

                cbSV.Enabled = false;
                cbMH.Enabled = false;
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maSV = cbSV.SelectedValue.ToString();
            String maMH = cbMH.SelectedValue.ToString();
            String sql = "delete from diem where mssv = '"+ maSV +"' and ma_mh = '"+ maMH +"'";

            if (connect.CapnhatCSDL(sql))
                MessageBox.Show("Xóa dữ liệu thành công");
            else MessageBox.Show("Xóa dữ liệu không thành công");

            hienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String maSV = cbSV.SelectedValue.ToString().Trim();
                String maMH = cbMH.SelectedValue.ToString().Trim();
                float diemLan1 = float.Parse(txtDL1.Text.ToString());  
                float diemLan2 = float.Parse(txtDL2.Text.ToString());
                float diemKetThuc = float.Parse(txtDKT.Text.ToString());

                String sql = "update diem set diem_lan_1= "+diemLan1+", diem_lan_2="+diemLan2+" , diem_ket_thuc="+diemKetThuc+" where mssv='"+ maSV +"' and ma_mh='"+ maMH +"'";
                MessageBox.Show(sql);
                if (connect.CapnhatCSDL(sql))
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                else MessageBox.Show("Cập nhật dữ liệu không thành công");

                hienThiDuLieu();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Cập nhật dữ liệu không thành công");
            }
        }
    }
}
