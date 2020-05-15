using System;
using System.Collections;
using System.Windows.Forms;
namespace bt_kndl
{
    public partial class frm_chinh : Form
    {
        ArrayList dsKhachhang = new ArrayList();
        public frm_chinh()
        {
            InitializeComponent();

        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuibapDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuibapDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.cuibapDataSet.SinhVien);
            btn_sua.Enabled = false;
            btn_thongtin.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xoahet.Enabled = false;

        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            frm_thongtin frmkh = new frm_thongtin();
            KhachHang kh = new KhachHang();
            if (index >= 0)
            {
                
                kh = (KhachHang)dsKhachhang[index];
                frmkh.txt_hoten.Text = kh.hoten;
                if (kh.gioitinh) frmkh.rb_nam.Checked = true;
                else frmkh.rb_nam.Checked = true;
                frmkh.txt_namsinh.Text = kh.namsinh.ToString();
                frmkh.txt_sodt.Text = kh.dienthoai;
                frmkh.txt_diachi.Text = kh.diachi;
                frmkh.ShowDialog();
                frmkh.btn_ok.Enabled = false;
            }
            
        }
        private void CapNhatDanhSachKhachHang()
        {
            KhachHang kh = new KhachHang();
            lbKhachHang.Items.Clear();
            for (int i = 0; i < dsKhachhang.Count; i++)
            {
                kh = (KhachHang)dsKhachhang[i];
                lbKhachHang.Items.Add(kh.hoten);
            }

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_thongtin frmkh = new frm_thongtin();
            KhachHang kh = new KhachHang();
            if (frmkh.ShowDialog() == DialogResult.OK)
            {
                kh.hoten = frmkh.txt_hoten.Text.ToString();
                kh.gioitinh = frmkh.rb_nam.Checked;
                kh.namsinh = Int32.Parse(frmkh.txt_namsinh.Text);
                kh.dienthoai = frmkh.txt_sodt.Text;
                kh.diachi = frmkh.txt_diachi.Text;
                dsKhachhang.Add(kh);
                CapNhatDanhSachKhachHang();
                btn_sua.Enabled = true;
                btn_thongtin.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoahet.Enabled = true;
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            if (index >= 0)
            {
                dsKhachhang.RemoveAt(index);
                lbKhachHang.Items.RemoveAt(index);
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            frm_thongtin frmkh = new frm_thongtin();
            KhachHang kh = new KhachHang();
            if (index >= 0)
            {
                kh = (KhachHang)dsKhachhang[index];
                frmkh.txt_hoten.Text = kh.hoten;
                if (kh.gioitinh) frmkh.rb_nam.Checked = true;
                else frmkh.rb_nam.Checked = true;
                frmkh.txt_namsinh.Text = kh.namsinh.ToString();
                frmkh.txt_sodt.Text = kh.dienthoai;
                frmkh.txt_diachi.Text = kh.diachi;
                if (frmkh.ShowDialog() == DialogResult.OK)
                {
                    kh.hoten = frmkh.txt_hoten.Text;
                    kh.gioitinh = frmkh.rb_nam.Checked;
                    kh.namsinh = Int32.Parse(frmkh.txt_namsinh.Text);
                    kh.dienthoai = frmkh.txt_sodt.Text;
                    kh.diachi = frmkh.txt_diachi.Text;
                    dsKhachhang[index] = kh;
                    CapNhatDanhSachKhachHang();
                }

            }

        }

        private void btn_xoahet_Click(object sender, EventArgs e)
        {
            dsKhachhang.Clear();
            CapNhatDanhSachKhachHang();
        }
    }
}

