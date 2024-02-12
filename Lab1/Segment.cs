using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Point(double x, double y)
    {
        public double x = x;
        public double y = y;
    }
    class Segment
    {
        public Point start;
        public Point end;

        public Segment()
        {
            start = new Point(0, 0);
            end = new Point(0, 0);
        }

        public Segment(double x1, double y1, double x2, double y2)
        {
            start = new Point(x1, y1);
            end = new Point(x2, y2);

            if (x1 > x2) (start, end) = (end, start);
            
        }
    }
}
