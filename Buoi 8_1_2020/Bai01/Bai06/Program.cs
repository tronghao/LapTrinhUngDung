using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Nhap so thu nhat: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            b = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            c = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so thu tu: ");
            d = Int32.Parse(Console.ReadLine());

            int max1 = Math.Max(a, b);
            int max2 = Math.Max(max1, c);
            int max3 = Math.Max(max2, d);

            Console.WriteLine("    => So Lon nhat la: {0}", max3);
            Console.ReadLine();
        }
    }
}
