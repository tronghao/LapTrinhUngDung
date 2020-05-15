using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;

            Console.WriteLine("Xem 3 canh co phai la tam giac khong!");
            Console.Write("Nhap a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (a == b || b == c || c == a)
                        Console.WriteLine("  => Tam giac vuong can");
                    else Console.WriteLine("  => Tam giac vuong");
                }
                else if (a == b && b == c)
                    Console.WriteLine("   => Tam giac deu");
                else if (a == b || b == c || c == a)
                    Console.WriteLine("   => Tam giac can");
                else Console.WriteLine("   => Tam giac thuong");
            }
            else Console.WriteLine("   => Khong phai la ba canh cua tam giac!");

            Console.ReadLine();
        }
    }
}
