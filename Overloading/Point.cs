using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public struct Point : IComparable
    {
        private int x, y;

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public static int operator >=(Point a, Point b)
        {
            return a.CompareTo(b);
        }

        public static int operator <=(Point a, Point b)
        {
            return b.CompareTo(a);
        }
        public int CompareTo(object? obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;

                if (this.x >= p.x && this.y >= p.y)
                {
                    return 1;
                }
                else if (this.x <= p.x && this.y <= p.y)
                {
                    return -1;
                }
                else if (this.x >= p.x && this.y <= p.y)
                {
                    return -2;
                }
                else if (this.x <= p.x && this.y >= p.y)
                {
                    return -3;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
