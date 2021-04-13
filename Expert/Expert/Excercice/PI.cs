using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class PI
    {
        public class Point
        {
            public double x, y;
        }
        public static double Approx(Point[] pts)
        {
            int v = 0;
            foreach (Point pt in pts)
            {
                if (((float)Math.Pow(pt.x, 2) + (float)Math.Pow(pt.y, 2)) <= 1)
                {
                    v++;
                }
            }
            return (4f * v / (float)pts.Length);

        }
    }
}
