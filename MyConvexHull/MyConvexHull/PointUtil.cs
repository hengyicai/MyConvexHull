using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvexHull
{
    class PointUtil
    {
        public static float Dist(Point a, Point b)
        {
            return (a.getX() - b.getX()) * (a.getX() - b.getX())
                + (a.getY() - b.getY()) * (a.getY() - b.getY());
        }

        // 返回（p,q,r）三点构成的拐向
        // 三点共线 --> 返回0
        // 右拐（顺时针） --> 返回1
        // 左拐 （逆时针）--> 返回2
        public static int Orientation(Point p, Point q, Point r)
        {
            float  val = (q.getY() - p.getY()) * (r.getX() - q.getX())
                - (q.getX() - p.getX()) * (r.getY() - q.getY());
            if (val == 0) return 0;
            return (val > 0) ? 1 : 2;
        }

        // 比较两点与初始点的极角
        public static int Compare(Point p1, Point p2)
        {
            int ori = Orientation(FirstPoint.Get(), p1, p2);
            if (ori == 0)
                return (Dist(FirstPoint.Get(), p2) >= Dist(FirstPoint.Get(), p1)) ? -1 : 1;
            return (ori == 2) ? -1 : 1;
        }
    }
}
