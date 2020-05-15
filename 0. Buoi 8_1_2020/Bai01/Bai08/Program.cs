using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, luaChon;
            Console.Write("Nhap so thu nhat: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n1.Cong\n2.Tru\n3.Nhan\n4.Chia");
            Console.Write("Lua chon cua ban: ");
            luaChon = Int32.Parse(Console.ReadLine());

            switch(luaChon)
            {
                case 1:
                    Console.WriteLine("\n {0} + {1} = {2}", a, b, a + b);
                    break;
                case 2:
                    Console.WriteLine("\n {0} - {1} = {2}", a, b, a - b);
                    break;
                case 3:
                    Console.WriteLine("\n {0} * {1} = {2}", a, b, a * b);
                    break;
                case 4:
                    Console.WriteLine("\n {0} / {1} = {2}", a, b, (float)a / b);
                    break;
                default:
                    Console.WriteLine("\n Khong hop le");
                    break;
            }

            Console.ReadLine();
        }
    }
}
