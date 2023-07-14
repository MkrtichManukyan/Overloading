using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public struct And
    {
        private bool x, y;

        public And(bool a, bool b)
        {
            x = a;
            y = b;
        }

        public static bool operator &(And a, And b)
        {
            return a.Equals(b);
        }

        public override bool Equals(object o)
        {
            if (o is And)
            {
                if (((And)o).x == this.x && ((And)o).y == this.y)
                    return true;
            }
            return false;
        }
    }
}
