using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Complex
    {
        public double a;
        public double b;
    }

    public class Calculator
    {

        public Complex[] Sqrt(double x)
        {
            Complex[] r = { new Complex(), new Complex() };

            if (x >= 0)
            {
                r[0].a = Math.Sqrt(x);
                r[0].b = 0;
                r[1] = r[0];
            }
            else
            {
                r[0].a = 0;
                r[0].b = Math.Sqrt(x);
                r[1].a = 0;
                r[1].b = -Math.Sqrt(x);
            }
            return r;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            double x = -81;

            Complex[] result = { new Complex(), new Complex() };
            Complex[] expected = { new Complex(), new Complex() };

            expected[0].a = 0.0;
            expected[0].b = 9.0;
            expected[1].a = 0.0;
            expected[1].b = -9.0;

            Calculator Calc = new Calculator();

            result = Calc.Sqrt(x);

        }
    }
}
