using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, x1, x2, delta;

            Console.WriteLine("PT: ax^2 + bx + c = 0");
            Console.Write("Nhap a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0 && c != 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if(b==0 && c==0)
                {
                    Console.WriteLine("Phuong trinh co nghiem x = 0");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem x = {0}", -c / b);
                }

            }
            else
            {
                delta = b * b - 4 * a * c;

                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep x = {0}", -b / (2 * a));
                else
                {
                    x1 = (-b - Math.Sqrt(delta) / (2 * a));
                    x2 = (-b + Math.Sqrt(delta) / (2 * a));
                    Console.WriteLine("Phuong trinh co hai nghiem x1={0}, x2={1}", x1, x2);
                }

            }

            Console.ReadLine();
        }
    }
}
