using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvexHull
{
    public class Convex
    {
        public static List<Point> Convexhull(List<Point> pLists)
        {
           

            //首先确定初始点
            float yMin = pLists[0].getY();
            int minIndex = 0;
            foreach (Point p in pLists)
            {
                float y = p.getY();

                if ((y < yMin) || (yMin == y && p.getX() == pLists[minIndex].getX()))
                {
                    yMin = y;
                    minIndex = pLists.IndexOf(p);
                }
            }

            Point FP = FirstPoint.Create(pLists[minIndex].getX(), pLists[minIndex].getY());
            pLists.RemoveAt(minIndex);

            pLists.Sort();

            Stack<Point> S = new Stack<Point>();

            MyStack ST = new MyStack(S);
            ST.getStack().Push(FP);
            ST.getStack().Push(pLists[0]);
            ST.getStack().Push(pLists[1]);


            //处理剩下的 N-3 个点
            for (int i = 2; i < pLists.Count(); i++)
            {
                while (PointUtil.Orientation(ST.nextToTop(), ST.getStack().Peek(), pLists[i]) != 2)
                    ST.getStack().Pop();
                ST.getStack().Push(pLists[i]);
            }

            List<Point> retList = ST.getStack().ToList();
            retList.Sort();

            return retList;
        }
    }
}
