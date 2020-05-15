using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap so thu nhat: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Uoc chung lon nhat: {0}", ucln(a, b));
            Console.ReadLine();
        }

        static int ucln(int a, int b)
        {
            int min = Math.Min(a, b);
            for(int i=min; i>0; i--)
            {
                if (a % i == 0 && b % i == 0)
                    return i;
            }
            return 1;
        }
    }
}
