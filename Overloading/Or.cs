using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public struct Or
    {
        private bool x, y;

        public Or(bool a, bool b)
        {
            x = a;
            y = b;
        }

        public static bool operator |(Or a, Or b)
        {
            return a.Equals(b);
        }

        public override bool Equals(object o)
        {
            if (o is Or)
            {
                if (((Or)o).x == true || ((Or)o).y == true)
                    return true;
            }
            return false;
        }
    }
}
