using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Thast
{
    internal class Cylinder
    {
        private protected Point point1 { get; set; }
        private protected Point point2 { get; set; }
        private int Height { get; set; }

        public Cylinder(Point centerCircle, Point circle, int height)
        {
            point1 = centerCircle;
            point2 = circle;
            Height = height;
        }

        public Point GetPoint() 
        {
            return point1;
        }

        public Point GetCircle() 
        {
            return point2;
        }

        public int GetHeight() 
        {
            return Height;
        }

        public virtual double GetBaseArea()
        {
            return Math.PI * Point.GetDistance(point1, point2);
        }

        public virtual double GetLine()
        {
            return 2 * Math.PI * Point.GetDistance(point1, point2);
        }

        public virtual double GetVolume()
        {
            return GetBaseArea() * Height;
        }

        public virtual double GetCircleSideSurface()
        {
            return GetLine() * Height;
        }

    }
}
