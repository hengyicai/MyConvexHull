using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvexHull
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Point> pl = new List<Point>();
       
            Random ran = new Random();
            int num = 10000;

            for (int i = 0; i < num; i++)
            {
                Point p = new Point(float.Parse(ran.Next(0, 1000000).ToString()), 
                    float.Parse(ran.Next(0, 1000).ToString()));
                pl.Add(p);
            }
            pl = pl.Distinct().ToList<Point>();
            int bt = DateTime.Now.Millisecond;
            List<Point> rp = Convex.Convexhull(pl);
            int et = DateTime.Now.Millisecond;

            Console.WriteLine(et - bt);

            Console.ReadKey();

        }
    }
}
