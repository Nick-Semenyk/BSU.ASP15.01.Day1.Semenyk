using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonsSqrt
{
    public class NewtonsSqrt
    {
        //public static double EPS { get; set; } = 0.01; //C#6 ?
        private static double _EPS = 0.01;
        public static double EPS
        {
            get 
            {
                return _EPS;
            }
            set 
            {
                _EPS = value;
            } 
        }

        public static double Calculate(double x, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }
            if (x < 0 && n%2 == 0)
            {
                return double.NaN;
                //throw new ArgumentException();
            }
            double xCurr;
            double xNext = 1;
            double xCurrPow;
            do
            {
                xCurr = xNext;
                xCurrPow = 1;
                for (int i = 0; i < n - 1; i++)
                {
                    xCurrPow *= xCurr;
                }
                xNext = ((n - 1) * xCurr + x / xCurrPow) / n;
            } while (Math.Abs(xCurr - xNext) > EPS);
            return xNext;
        }
    }
}
