using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class SegmentIntersection
    {
        //Определение точки пересечения двух отрезков, один из которых вертикальный
        private static Segment OneVerticalSegment(Segment noIntersection, Segment vertical, Segment common)
        {
            double k = (common.start.y - common.end.y) / (common.start.x - common.end.x);
            double b = common.start.y - k * common.start.x;

            double y = k * vertical.start.x + b;

            if (y <= Math.Max(vertical.start.y, vertical.end.y) && y >= Math.Min(vertical.start.y, vertical.end.y))
                return new Segment(Math.Round(vertical.start.x, 2), Math.Round(y, 2), double.NaN, double.NaN);

            return noIntersection;
        }

        //Определение точки/промежутка пересечения двух отрезков
        public static Segment Intersection(Segment first, Segment second)
        {
            const double precision = 0.00001;
            Segment noIntersection = new(double.NaN, double.NaN, double.NaN, double.NaN);

            //Слишком далеко по оси абсцисс
            if (first.end.x < second.start.x) return noIntersection;

            //Оба отрезка вертикальные
            if ((first.end.x - first.start.x < precision) && (second.start.x - second.end.x < precision))
            {
                //Оба отрезка лежат на одной прямой
                if (first.start.x - second.start.x < precision)
                {
                    //Отрезки накладываются
                    if (!((Math.Max(first.start.y, first.end.y) < Math.Min(second.start.y, second.end.y)) ||
                        (Math.Min(first.start.y, first.end.y) > Math.Max(second.start.y, second.end.y))))
                    {
                        return new Segment(Math.Round(first.start.x, 2),
                            Math.Round(Math.Max(Math.Min(first.start.y, first.end.y), Math.Min(second.start.y, second.end.y)), 2),
                            Math.Round(second.start.x, 2),
                            Math.Round(Math.Min(Math.Max(first.start.y, first.end.y), Math.Max(second.start.y, second.end.y)), 2));
                    }
                        
                    return noIntersection;
                }
            }

            //Если только первый отрезок вертикальный
            if (first.end.x - first.start.x < precision)
                return OneVerticalSegment(noIntersection, first, second);
 


            //Если только второй отрезок вертикальный
            if (second.end.x - second.start.x < precision)
                return OneVerticalSegment(noIntersection, second, first);


            //Общий случай

            double k1 = (first.start.y - first.end.y) / (first.start.x - first.end.x);
            double k2 = (second.start.y - second.end.y) / (second.start.x - second.end.x);

            double b1 = first.start.y - k1 * first.start.x;
            double b2 = second.start.y - k1 * second.start.x;

            //Если угловые коэффициенты не равны
            if(k1 - k2 != 0)
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                return new Segment(Math.Round(x, 2), Math.Round(y, 2), double.NaN, double.NaN);
            }

            //Если отрезки накладываются друг на друга
            if(b1 - b2 == 0)
            {
                double x1 = Math.Max(first.start.x, second.start.x);
                double x2 = Math.Min(first.end.x, second.end.x);

                double y1 = k1 * x1 + b1;
                double y2 = k1 * x2 + b1;

                return new Segment(x1, Math.Round(y1, 2), x2, Math.Round(y2, 2));
            }

            return noIntersection;

        }
    }
}
