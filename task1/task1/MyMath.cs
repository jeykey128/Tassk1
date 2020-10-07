using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class MyMath
    {
        public static double Arctg(double x, int n, ref double LastElem)
        {
            double sum = x;
            LastElem = x;
            for (int i = 2; i <= n; i++)
            {
                sum += LastElem * -(x * x * (2 * (i - 1) + 3) / (2 * i + 3));
                LastElem = LastElem * -(x * x * (2 * (i - 1) + 3) / (2 * i + 3));
            }
            return sum;
        }

        public static double SumLast(double x, double E, ref int N)
        {
            double sum = 0;
            double pred = x;
            for (int i = 2; Math.Abs(pred) > E; i++)
            {
                sum += pred;
                N++;
                pred = (x * x * (2 * (i - 1) + 3) / (2 * i + 3));
                pred = -1 * pred;
            }
            return sum;
        }
    }
}
