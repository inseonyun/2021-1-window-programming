using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalcWindowApp
{
    class ComplexArray
    {
        Complex [] c = new Complex[3];
        public static int count = 0;

        public Complex this[int count]
        {
            get
            {
                return c[count];
            }
            set
            {
                c[count] = value;
            }
        }
    }
}
