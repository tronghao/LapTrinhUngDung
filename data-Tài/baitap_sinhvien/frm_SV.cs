using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_sinhvien
{
    public partial class frm_SV : Form
    {
        TV_kndl kn;

        public frm_SV()
        {
            InitializeComponent();
            kn = new TV_kndl();
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_mssv.Enabled = false;
            if(kn.Moketnoi())
            {
                string str = "select * from Lop";
                cblop.DataSource = kn.LayBang(str);
                cblop.DisplayMember = "TenLop";
                cblop.ValueMember = "MaLop";

                str = "select * from SinhVien";
                dgv_thongtin.DataSource = kn.LayBang(str);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuibapDataSet1.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.cuibapDataSet1.Lop);

        }
        void hienluoi()
        {
            string str = "select * from SinhVien";
            dgv_thongtin.DataSource = kn.LayBang(str);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_hoten.Text==""||txt_mssv.Text=="")
            {
                MessageBox.Show("Nhập lại đi", "Thông báo!");
                return;
            }
            string str = "insert into SinhVien values('"+txt_mssv.Text.Trim()+"',N'"+txt_hoten.Text.Trim()+"',N'"+cblop.SelectedValue.ToString()+"')";
            kn.CapnhatCSDL(str);
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
            txt_mssv.Enabled = false;
            txt_hoten.Text = "";
            txt_mssv.Text = "";

            hienluoi();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mssv.Text == "")
            {
                MessageBox.Show("Nhập lại đi", "Thông báo!");
                return;
            }
            string str = " delete from SinhVien where MSSV='" + txt_mssv.Text.Trim() + "'";
            kn.CapnhatCSDL(str);
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_hoten.Text = "";
            txt_mssv.Text = "";

            hienluoi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "" || txt_mssv.Text == "")
            {
                MessageBox.Show("Nhập mã số cần sửa!!", "Thông báo!");
                return;
            }
            string str = "update SinhVien set HoTen = N'" + txt_hoten.Text.Trim() + "', MaLop='" + cblop.SelectedValue.ToString() + "' where MSSV='" + txt_mssv.Text.Trim() + "'";
            kn.CapnhatCSDL(str);
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
            txt_hoten.Text = "";
            txt_mssv.Text = "";

            hienluoi();
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_mssv.Text = dgv_thongtin[0, e.RowIndex].Value.ToString();
                txt_hoten.Text = dgv_thongtin[1, e.RowIndex].Value.ToString();
                cblop.SelectedValue = dgv_thongtin[2, e.RowIndex].Value.ToString();
            }catch
            {

            }
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_mssv.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_hoten.Text = "";
            txt_mssv.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frm_SV frm = new frm_SV();
            frm.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_mssv.Enabled = false;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_hoten.Text = "";
            txt_mssv.Text = "";
        }
    }
}
