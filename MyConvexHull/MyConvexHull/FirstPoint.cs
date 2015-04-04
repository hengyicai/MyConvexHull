using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvexHull
{
    // 初始点
    class FirstPoint
    {
        private static Point p;
      

        public static Point Create(float x,float y)
        {
            if (p == null)
            {
                p = new Point(x, y);
                return p;
            }
            else
            {
                return p;
            }
        }

        public static Point Get()
        {
            return p;
        }
    }
}
