using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class date
    {
        int ngay;
        int thang;
        int nam;

        public int NGAY
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public int THANG
        {
            get { return thang; }
            set { thang = value; }
        }

        public int NAM
        {
            get { return nam; }
            set { nam = value; }
        }

        public date(int d, int m, int y)
        {
            if (d < 0 || d > 31)
            {
                ngay = 1;
            }
            else
            {
                ngay = d;
            }

            if (m < 0 || m > 12)
            {
                thang = 1;
            }
            else
            {
                thang = m;
            }

            if (y < 0 )
            {
                thang = 1990;
            }
            else
            {
                thang = y;
            }

        }
        void nhap()
        {
            Console.Write("Nhap Ngay: ");
            ngay = Console.Read();

            Console.Write("\nNhap Thang: ");
            thang = Console.Read();

            Console.Write("\nNhap Nam: ");
            nam = Console.Read();
        }

        void xuat()
        {
            Console.Write("DATE: " + ngay + "/" + thang + "/" + nam);
        }

    }
}
