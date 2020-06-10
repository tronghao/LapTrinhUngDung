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
    public partial class FormSV : Form
    {
        tvkn_csdl csdl = new tvkn_csdl();

        public FormSV()
        {
            InitializeComponent();
            hienThiDuLieu();
            
        }

        public void hienThiDuLieu()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
          
            txtMaSV.ReadOnly = false;
            DataTable bangLop = new DataTable();
            String sql = "select ma_sv as 'Mã SV', ten_sv as 'Tên SV', ten_lop as 'Tên Lớp' from lop, sinhvien where lop.ma_lop = sinhvien.ma_lop";
            bangLop = csdl.LayBang(sql);
            dgv.DataSource = bangLop;

            DataTable bangsinhvien = new DataTable();
            sql = "select * from lop";
            bangsinhvien = csdl.LayBang(sql);

            cbTenLop.DataSource = bangsinhvien;
            cbTenLop.DisplayMember = "ten_lop";
            cbTenLop.ValueMember = "ma_lop";

        }

        private void cậpNhậtLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm_lop = new Form1();
            this.Visible = false;
            frm_lop.Show();
        }

        private void cậpNhậtSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSV frm_sv = new FormSV();
            this.Visible = false;
            frm_sv.Show();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int index = cbTenLop.SelectedIndex;
            String maSV = txtMaSV.Text;
            String tenSV = txtTenSV.Text;
            String maLop = cbTenLop.SelectedValue.ToString();
            String sql = "insert into sinhvien values('" + maSV + "', N'" + tenSV + "', '" + maLop + "')";
            if (csdl.CapnhatCSDL(sql))
                MessageBox.Show("Lưu thành công");
            else MessageBox.Show("Lưu không thành công");
            hienThiDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text;
            String sql = "delete sinhvien where ma_sv = '" + maSV + "'";
            if (csdl.CapnhatCSDL(sql))
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa không thành công");
            hienThiDuLieu();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaSV.Text = dgv.Rows[index].Cells[0].Value.ToString();
            txtTenSV.Text = dgv.Rows[index].Cells[1].Value.ToString();
            string giaTri = dgv.Rows[index].Cells[2].Value.ToString();
            //cbTenLop.ValueMember = dgv.Rows[index].Cells[2].Value.ToString();
            cbTenLop.SelectedIndex = cbTenLop.FindStringExact(giaTri);
            txtMaSV.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text;
            String tenSV = txtTenSV.Text;
            String maLop = cbTenLop.SelectedValue.ToString();
            String sql = "update sinhvienz set ten_sv = N'" + tenSV + "', ma_lop = '" + maLop + "' where ma_sv = '" + maSV + "'";
            if (csdl.CapnhatCSDL(sql))
                MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật không thành công");
            hienThiDuLieu();
        }
    }
}
