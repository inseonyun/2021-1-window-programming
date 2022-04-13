using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointIndexerWindowApp
{
    class PointArray
    {
        Point[] p = new Point[10];
        public static int count = 0;

        public Point this[int count]
        {
            get
            {
                return p[count];
            }
            set
            {
                p[count] = value;
            }
        }
    }
}
