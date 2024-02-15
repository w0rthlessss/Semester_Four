using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    
    public class Segment
    {
        public class Point(double x, double y)
        {
            public double x = x;
            public double y = y;
        }

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

        public override bool Equals(object? obj)
        {
            if(obj == null || !(obj is Segment)) return false;

            Segment other = (Segment)obj;

            return double.IsNaN(this.start.x) && double.IsNaN(other.start.x) || this.start.x.Equals(other.start.x) &&
                double.IsNaN(this.start.y) && double.IsNaN(other.start.y) || this.start.y.Equals(other.start.y) &&
                double.IsNaN(this.end.x) && double.IsNaN(other.end.x) || this.end.x.Equals(other.end.x) &&
                double.IsNaN(this.end.y) && double.IsNaN(other.end.y) || this.end.y.Equals(other.end.y);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
