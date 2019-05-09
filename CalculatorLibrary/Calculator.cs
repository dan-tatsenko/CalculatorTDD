using System;

namespace CalculatorLibrary
{
    //All complex numbers#
    //contains two components:
    //a - real component
    //b - imaginary component
    //i*i = -1
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

        public Complex[] Sqrt(double x) //Function returns two values - array[2]
        {
            //r - array stores results
            // each element of array is complex number

            //Creates array of results
            //Each element is instance of class Complex
            //because each result of function SQRT is complex number
            Complex[] r = { new Complex(), new Complex() };

            if (x>=0)
            {
                //Both results are equal
                //and contain only real component of complex number
                r[0].a = Math.Sqrt(x);  //real component
                r[0].b = 0;             //imaginary component (coefficient before i)

                r[1].a = Math.Sqrt(x);  //real component
                r[1].b = 0;             //imaginary component (coefficient before i)
            }
            else //We try to calculate SQRT(negative number)
            {
                r[0].a = 0;                 //real component a=0
                //-x to make variable positive (to avoid compiler error)
                r[0].b = Math.Sqrt(-x);     //imaginary component of complex number

                r[1].a = 0;                 //real component a=0
                //-x to make variable positive (to avoid compiler error)
                r[1].b = -Math.Sqrt(-x);    //imaginary component of complex number
            }
            return r; 
        }

    }
}
