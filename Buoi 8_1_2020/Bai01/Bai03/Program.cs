using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Nhap so: ");
            num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("   => so chan");
            else Console.WriteLine("   => so le");

            Console.ReadLine();
        }
    }
}
