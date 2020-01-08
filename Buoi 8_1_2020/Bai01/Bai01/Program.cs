using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Double diemToan, diemLy, diemHoa;

            Console.Write("Nhap diem toan: ");
            diemToan = Double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            diemLy = Double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            diemHoa = Double.Parse(Console.ReadLine());

            Double diemTB =((diemToan + diemLy + diemHoa) / 3);


            Console.WriteLine("\n---------Ket qua nhap:-----------");
            Console.WriteLine("Diem toan: {0}", diemToan);
            Console.WriteLine("Diem ly: {0}", diemLy);
            Console.WriteLine("Diem hoa: {0}", diemHoa);
            Console.WriteLine("Diem Trung Binh: {0}", diemTB);

            if (diemTB >= 8.5)
                Console.WriteLine("   =>Gioi");
            else if (diemTB >= 6.5)
                Console.WriteLine("   =>Kha");
            else if (diemTB >= 5.0)
                Console.WriteLine("   =>Trung Binh");
            else Console.WriteLine("   =>Yeu");

            Console.ReadLine();
        }
    }
}
