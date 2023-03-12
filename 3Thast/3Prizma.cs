using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _3Thast
{
    internal class _3Prizma : Cylinder
    {
        private protected Point point3 { get; set; }

        public _3Prizma(Point point1, Point point2, Point point3, int height)
            :base(point1, point2, height) 
        {
            this.point3 = point3;
        }

        public override double GetLine()
        {
            double st1 = Point.GetDistance(point3, point2);
            double st2 = Point.GetDistance(point3, point1);
            double st3 = Point.GetDistance(point2, point1);
            return st1 + st2 + st3;
        }

        public override double GetBaseArea()
        {
            double st1 = Point.GetDistance(point3, point2);
            double st2 = Point.GetDistance(point3, point1);
            double st3 = Point.GetDistance(point2, point1);
            double polyperimetr = (st1 + st2 + st3) / 2.0;
            double plothat = Math.Sqrt(polyperimetr * (polyperimetr - st1) * (polyperimetr - st2) * (polyperimetr - st3));
            return plothat;
        }
    }
}
