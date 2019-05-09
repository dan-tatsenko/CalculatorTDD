using System;

namespace CalculatorLibrary
{
    public class Complex
    {
        public double a;
        public double b;
    }

    public class Calculator
    {
    

        public double Add (double A, double B)
        {
            return A+B;
        }

        public double Substruction(double A, double B)
        {
            return A - B;
        }

        public double Multiplication(double A, double B)
        {
            return A * B;
        }

        public double Division(double A, double B)
        {
            if (B!=0)
            {
                return A / B;
            }
            else return double.NaN;   
        }

        public Complex[] Sqrt(double x)
        {
            Complex[] r = { new Complex(), new Complex() };

            if (x>=0)
            {
                r[0].a = Math.Sqrt(x);
                r[0].b = 0;
                r[1].a = Math.Sqrt(x);
                r[1].b = 0;
            }
            else
            {
                r[0].a = 0;
                r[0].b = Math.Sqrt(-x);
                r[1].a = 0;
                r[1].b = -Math.Sqrt(-x);
            }
            return r; 
        }

    }
}
