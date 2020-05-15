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

namespace Bt3_22_04_20
{
    public partial class Form1 : Form
    {
        ArrayList dsKhachhang = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmKhachHang frmkh = new frmKhachHang();
            KhachHang kh = new KhachHang();
            if (frmkh.ShowDialog() == DialogResult.OK)
            {
                kh.hoten = frmkh.tbHoten.Text;
                kh.gioitinh = frmkh.rbGioitinh.Checked;           
                kh.namsinh = Int32.Parse(frmkh.tbNamsinh.Text);
                kh.dienthoai = frmkh.tbDienthoai.Text;
                kh.diachi = frmkh.tbDiachi.Text;
                dsKhachhang.Add(kh);
                CapNhatDanhSachKhachHang();
                btSua.Enabled = true;
                btXemThongTin.Enabled = true;
                btXoa.Enabled = true;
                btXoaHet.Enabled = true;
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
        private void btSua_Click_1(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            frmKhachHang frmkh = new frmKhachHang();
            KhachHang kh = new KhachHang();
            if (index >= 0)
            {
                kh = (KhachHang)dsKhachhang[index];
                frmkh.tbHoten.Text = kh.hoten;
                if (kh.gioitinh) frmkh.rbGioitinh.Checked = true;
                else frmkh.rbaGioitinh.Checked = true;
                frmkh.tbNamsinh.Text = kh.namsinh.ToString();
                frmkh.tbDienthoai.Text = kh.dienthoai;
                frmkh.tbDiachi.Text = kh.diachi;
                if (frmkh.ShowDialog() == DialogResult.OK)
                {
                    kh.hoten = frmkh.tbHoten.Text;
                    kh.gioitinh = frmkh.rbGioitinh.Checked;
                    kh.namsinh = Int32.Parse(frmkh.tbNamsinh.Text);
                    kh.dienthoai = frmkh.tbDienthoai.Text;
                    kh.diachi = frmkh.tbDiachi.Text;
                    dsKhachhang[index] = kh;
                    CapNhatDanhSachKhachHang();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            if (index >= 0)
            {
                dsKhachhang.RemoveAt(index);
                lbKhachHang.Items.RemoveAt(index);
            }

        }

        private void btXoaHet_Click(object sender, EventArgs e)
        {
            dsKhachhang.Clear();
            lbKhachHang.Items.Clear();
        }

        private void btXemThongTin_Click(object sender, EventArgs e)
        {
            int index = lbKhachHang.SelectedIndex;
            frmKhachHang frmkh = new frmKhachHang();
            KhachHang kh = new KhachHang();
            if (index >= 0)
            {
                kh = (KhachHang)dsKhachhang[index];
                frmkh.tbHoten.Text = kh.hoten;
                if (kh.gioitinh) frmkh.rbGioitinh.Checked = true;
                else frmkh.rbaGioitinh.Checked = true;
                frmkh.tbNamsinh.Text = kh.namsinh.ToString();
                frmkh.tbDienthoai.Text = kh.dienthoai;
                frmkh.tbDiachi.Text = kh.diachi;
                frmkh.tbHoten.Enabled = false;
                frmkh.tbNamsinh.Enabled = false;
                frmkh.tbDienthoai.Enabled = false;
                frmkh.tbDiachi.Enabled = false;
                frmkh.rbGioitinh.Enabled = false;
                frmkh.rbaGioitinh.Enabled = false;
                if (frmkh.ShowDialog() == DialogResult.OK)
                {
                    kh.hoten = frmkh.tbHoten.Text;
                    kh.gioitinh = frmkh.rbGioitinh.Checked;
                    kh.namsinh = Int32.Parse(frmkh.tbNamsinh.Text);
                    kh.dienthoai = frmkh.tbDienthoai.Text;
                    kh.diachi = frmkh.tbDiachi.Text;
                    dsKhachhang[index] = kh;
                    CapNhatDanhSachKhachHang();
                }

            }
        }
    }
}
