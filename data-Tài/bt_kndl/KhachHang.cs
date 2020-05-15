using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_kndl
{
    class KhachHang
    {
        public string hoten;
        public string dienthoai;
        public string diachi;
        public int namsinh;
        public bool gioitinh; //true la nam, ngược lại là nữ
        
        public KhachHang()
        {
            this.hoten = "";
            this.dienthoai = "";
            this.diachi = "";
            this.namsinh = 0;
            this.gioitinh = true;
        }
        public KhachHang(string hoten, string dienthoai, string diachi, int namsinh, bool gioitinh)
        {
            this.hoten = hoten;
            this.dienthoai = dienthoai;
            this.diachi = diachi;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
        }
        public int TinhTuoi()
        {
            int tuoi = DateTime.Now.Year - namsinh;
            return tuoi;
        }

    }
}
