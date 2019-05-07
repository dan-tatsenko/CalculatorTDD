using System;

namespace CalculatorLibrary
{
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
    }
}
