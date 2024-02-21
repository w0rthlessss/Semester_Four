using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class FunctionPoint
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public static class FunctionPoints
    {
        public static double[] GenerateX(double step, double leftBorder, double rightBorder)
        {
            int size = Convert.ToInt32((rightBorder-leftBorder) / step) + 1;
            double[] abscissa = new double[size];
            for(int i = 0; i < size; i++)
                abscissa[i] = leftBorder + i * step;
            
            return abscissa;
        }

        public static double[] GenerateY(double[] x, double[] odds)
        {
            double[] ordinate = new double[x.Length];

            for(int i = 0; i < x.Length; i++)
                ordinate[i] = Math.Round(odds[0] + odds[1] * Math.Sin(odds[2] * x[i] + odds[3]), 2);
            
            return ordinate;
        }

    }
}
