using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_03_doc
{
    public partial class Form1 : Form
    {
        ArrayList dsKhachhang = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnThongTin.Enabled = false;
            btnXoa.Enabled = false;
            btnXoaHet.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                xu_ly_them frmThem = new xu_ly_them();
                KhachHang kh = new KhachHang();
                if ( frmThem.ShowDialog() == DialogResult.OK)
                {
                    kh.hoten = frmThem.txtHoTen.Text;
                    kh.gioitinh = frmThem.radioGioiTinh.Checked;
                    kh.namsinh = Int32.Parse(frmThem.txtNamSinh.Text);
                    kh.dienthoai = frmThem.txtDienThoai.Text;
                    kh.diachi = frmThem.txtDiaChi.Text;
                    dsKhachhang.Add(kh);
                    cap_nhat_danh_sach_khach_hang();
                    btnSua.Enabled = true;
                    btnThongTin.Enabled = true;
                    btnXoa.Enabled = true;
                    btnXoaHet.Enabled = true;
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi thêm");
            }
        }

        public void cap_nhat_danh_sach_khach_hang()
        {
            KhachHang kh = new KhachHang();
            lbKhachHang.Items.Clear();
            for (int i = 0; i < dsKhachhang.Count; i++)
            {
                kh = (KhachHang)dsKhachhang[i];
                lbKhachHang.Items.Add(kh.hoten);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            if (index >= 0)
            {
                dsKhachhang.RemoveAt(index);
                lbKhachHang.Items.RemoveAt(index);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            xu_ly_them frmThem = new xu_ly_them();
            KhachHang kh = new KhachHang();
            if (index >= 0)
            {
                kh = (KhachHang)dsKhachhang[index];
                frmThem.txtHoTen.Text = kh.hoten;
                if (kh.gioitinh) frmThem.radioGioiTinh.Checked = true;
                else frmThem.radioNu.Checked = true;
                frmThem.txtNamSinh.Text = kh.namsinh.ToString();
                frmThem.txtDienThoai.Text = kh.dienthoai;
                frmThem.txtDiaChi.Text = kh.diachi;
                if (frmThem.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                       
                            kh.hoten = frmThem.txtHoTen.Text;
                            kh.gioitinh = frmThem.radioGioiTinh.Checked;
                            kh.namsinh = Int32.Parse(frmThem.txtNamSinh.Text);
                            kh.dienthoai = frmThem.txtDienThoai.Text;
                            kh.diachi = frmThem.txtDiaChi.Text;
                            dsKhachhang[index] = kh;
                            cap_nhat_danh_sach_khach_hang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm");
                    }
                    
                }

            }

        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            dsKhachhang.Clear();
            lbKhachHang.Items.Clear();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            xu_ly_them frmThem = new xu_ly_them();
            KhachHang kh = new KhachHang();
            if (index >= 0)
            {
                kh = (KhachHang)dsKhachhang[index];
                frmThem.txtHoTen.Text = kh.hoten;
                if (kh.gioitinh) frmThem.radioGioiTinh.Checked = true;
                else frmThem.radioNu.Checked = true;
                frmThem.txtNamSinh.Text = kh.namsinh.ToString();
                frmThem.txtDienThoai.Text = kh.dienthoai;
                frmThem.txtDiaChi.Text = kh.diachi;

                frmThem.txtDiaChi.ReadOnly = true;
                frmThem.txtDienThoai.ReadOnly = true;
                frmThem.txtHoTen.ReadOnly = true;
                frmThem.txtNamSinh.ReadOnly = true;
                frmThem.radioGioiTinh.Enabled = false;
                frmThem.radioNu.Enabled = false;
                frmThem.ShowDialog();
            }
        }
    }
}
