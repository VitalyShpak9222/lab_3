using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Thast
{
    internal class Point
    {
        private int x { get; set; }
        private int y { get; set; }

        public Point(int x, int y0)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public static double GetDistance(Point a, Point b)
        {
            int x = Math.Abs(a.x - b.x);
            int y = Math.Abs(a.y - b.y);
            return Math.Sqrt(x * x + y * y);
        }

        public override string ToString()
        {
            return $"{x},{y}";
        }

        public int X() 
        {
            return x;
        }

        public int Y() 
        {
            return y;
        }

    }
}
