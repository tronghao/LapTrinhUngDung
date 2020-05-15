using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n = ");
            n = Int32.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine("Tong tu 1 den {0} la: {1}", n, sum);
            Console.ReadLine();
        }
    }
}
