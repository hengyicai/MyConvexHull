using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvexHull
{
    public class MyStack : Stack<Point>
    {
        private Stack<Point> st;

        public MyStack(Stack<Point> stack)
        {
            this.st = stack;
        }
        public Point nextToTop()
        {
            Point topP = st.Pop();
            Point nextP = st.Peek();
            st.Push(topP);
            return nextP;
        }

        public Stack<Point> getStack()
        {
            return st;
        }

        public void printStack()
        {
            foreach (Point p in st)
            {
                Console.WriteLine(p.getX() + "    " + p.getY());
            }
        }
    }
}
