using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvexHull
{
    public class Point : IComparable<Point>
    {
        private float x;
        private float y;
        public Point(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }

        public float getX()
        {
            return this.x;
        }

        public float getY()
        {
            return this.y;
        }


        int IComparable<Point>.CompareTo(Point other)
        {
            return PointUtil.Compare(this, other);
        }

    }
}
