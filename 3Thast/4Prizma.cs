using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _3Thast
{
    internal class _4Prizma:_3Prizma
    {
        private Point point4 { get; set; }

        public _4Prizma(Point a, Point b, Point c, Point d, int height)
            :base(a, b, c , height) 
        {
            point4 = d;
        }

        public override double GetLine()
        {
            double st1 = Point.GetDistance(point1, point2);
            double st2 = Point.GetDistance(point1, point4);
            double st3 = Point.GetDistance(point3, point2);
            double st4 = Point.GetDistance(point3, point4);
            return st1 + st2 + st3 + st4;
        }

        public override double GetBaseArea()
        {
            double st1 = Point.GetDistance(point1, point2);
            double st2 = Point.GetDistance(point1, point4);
            double st3 = Point.GetDistance(point3, point2);
            double st4 = Point.GetDistance(point3, point4);
            double polyperimetr = GetLine() / 2.0;
            double diagonal = Point.GetDistance(point2, point4);
            double treug1 =  Math.Sqrt(polyperimetr * (polyperimetr - st1) * (polyperimetr - st2) * (polyperimetr - diagonal));
            double treug2 = Math.Sqrt(polyperimetr * (polyperimetr - st3) * (polyperimetr - st4) * (polyperimetr - diagonal));
            return treug1 + treug2;
        }

        public bool GetParallalepiped() 
        {
            double st1 = Point.GetDistance(point1, point2);
            double st2 = Point.GetDistance(point1, point4);
            double st3 = Point.GetDistance(point2, point4);
            if ((st1 * st1 + st2 * st2) == st3 * st3)
            {
                return false;
            }
            return true;
        }

        public bool GetPrimoiParallalepiped() 
        {
            double st1 = Point.GetDistance(point1, point2);
            double st2 = Point.GetDistance(point1, point4);
            double st3 = Point.GetDistance(point2, point4);
            if ((st1 * st1 + st2 * st2) == st3 * st3) 
            {
                return true;
            }
            return false;
        }

        public bool GetKub() 
        {
            double st1 = Point.GetDistance(point1, point2);
            double st2 = Point.GetDistance(point1, point4);
            if (st1 == GetHeight() && GetBaseArea() == st1 * st2) 
            {
                return true;
            }
            return false;

        }
    }
}
