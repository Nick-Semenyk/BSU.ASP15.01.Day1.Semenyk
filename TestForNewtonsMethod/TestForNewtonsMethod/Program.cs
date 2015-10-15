using System;
using System.Collections.Generic;
using System.Text;
using NewtonsSqrt;


namespace TestForNewtonsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 42;
            int n = 5;
            Console.WriteLine(Math.Pow(a, 1.0/n));
            NewtonsSqrt.NewtonsSqrt.EPS = 0.0001;
            Console.WriteLine(NewtonsSqrt.NewtonsSqrt.Calculate(a,n));
            Console.Read();
        }
    }
}
