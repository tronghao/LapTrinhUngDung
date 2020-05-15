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
    public partial class frm_Lop : Form
    {
        TV_kndl kn;
        public frm_Lop()
        {
            InitializeComponent();
            kn = new TV_kndl();
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_malop.Enabled = false;
            if (kn.Moketnoi())
            {
                string str = "select * from Lop";
                dgv_lop.DataSource = kn.LayBang(str);
            }
        }
        void hienluoi()
        {
            string str = "select * from Lop";
            dgv_lop.DataSource = kn.LayBang(str);
        }
        private void frm_Lop_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_malop.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_tenlop.Text = "";
            txt_malop.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_malop.Text == "")
            {
                MessageBox.Show("Chọn mã cần xóa", "Thông báo!");
                return;
            }
            string str = " delete from Lop where MaLop='" + txt_malop.Text.Trim() + "'";
            kn.CapnhatCSDL(str);
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_tenlop.Text = "";
            txt_malop.Text = "";

            hienluoi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenlop.Text == "" || txt_malop.Text == "")
            {
                MessageBox.Show("Nhập mã số cần sửa!!", "Thông báo!");
                return;
            }
            string str = "update Lop set TenLop = N'" + txt_tenlop.Text.Trim() + "' where MaLop='" + txt_malop.Text.Trim() + "'";
            kn.CapnhatCSDL(str);
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
            txt_tenlop.Text = "";
            txt_malop.Text = "";

            hienluoi();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tenlop.Text == "" || txt_malop.Text == "")
            {
                MessageBox.Show("Nhập lại đi", "Thông báo!");
                return;
            }
            string str = "insert into Lop values('" + txt_malop.Text.Trim() + "',N'" + txt_tenlop.Text.Trim() + "')";
            kn.CapnhatCSDL(str);
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
            txt_malop.Enabled = false;
            txt_tenlop.Text = "";
            txt_malop.Text = "";

            hienluoi();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_malop.Enabled = false;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            txt_tenlop.Text = "";
            txt_malop.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frm_Lop frm = new frm_Lop();
            frm.Close();
        }
    }
}
