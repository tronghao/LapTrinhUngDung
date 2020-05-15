using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class HCN
    {
        int cd, cr;

        public int CD
        {
            get { return cd; }
            set { cd = value; }
        }
        public int CR
        {
            get { return cr; }
            set { cr = value; }
        }
        public HCN(int d, int r)
        {
            if (d < 0 || d > 20)
            {
                cd = 10;
            }
            else
            {
                cd = d;
            }

            if (r < 0 || r > 20)
            {
                cr = 10;
            }
            else
            {
                cr = r;
            }
            
        }
        public HCN()
        {
            cd = 10;
            cr = 10;
        }

        public int tinhchuvi()
        {
            return (cd + cr) * 2;
        }

        public double tinhduongcheo()
        {
            return Math.Sqrt(cd * cd * 1.0 + cr * cr * 1.0);
        }

        public int tinhdientich()
        {
            return cd * cr;
        }
    }
}
