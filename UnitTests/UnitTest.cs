using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]//Declare that this method is test case
        [DataRow(17, 13, 30)]
        [DataRow(20, 1.3, 21.3)]
        [DataRow(20, -5, 15)]
        public void AddTest(double x, double y, double expected)
        {
            double result;
            //Create instance of class Calculator
            Calculator Calc = new Calculator();
           
            //Sum two numbers
            result = Calc.Add(x,y);
            //Assert that expected value is equal to result
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //Using diferent data for test case
        [DataRow(100,10, 90)]
        [DataRow(20, 0, 20)]
        [DataRow(20, -5, 25)]
        public void SubstructionTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            //Call method Substruction of class Calculator
            result = Calc.Substruction(x, y);
            //Assert that expected value is equal to result
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 10, 50)]
        [DataRow(3.0, 3.3, 9.9)]
        [DataRow(20, -5, -100)]
        [DataRow(20, 0, 0)]
        public void MultiplicationTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            result = Calc.Multiplication(x, y);
            //Method compares result and expected value.
            //Returns TRUE when result differs from expected no more
            //than DELTA = 0.00001
            //it needs to compare double numbers with decimal 
            Assert.AreEqual(expected, result, 0.00001);
        }

        [TestMethod]
        [DataRow(22, 4, 5.5)]
        [DataRow(0, 5, 0)]
        [DataRow(20, -5, -4)]
        [DataRow(20, 0.0, double.NaN)] //division by zero return NaN
        public void DivisionTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            result = Calc.Division(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SqrtPositiveTest()
        {
            double x = 25;
            //All complex numbers#
            //contains two components:
            //a - real component
            //b - imaginary component
            //i*i = -1


            //array with results
            Complex[] result = { new Complex(), new Complex() };
            
            //array with expected values
            Complex[] expected = { new Complex(), new Complex() };

            //each element of array is complex number,
            //which has two components - a and b
            expected[0].a = 5.0;
            expected[0].b = 0.0;

            expected[1].a = 5.0;
            expected[1].b = 0.0;

            Calculator Calc = new Calculator();

            result = Calc.Sqrt(x);

            //Compare each component of each results (array of two elemets)
            Assert.AreEqual(expected[0].a, result[0].a);
            Assert.AreEqual(expected[0].b, result[0].b);

            Assert.AreEqual(expected[1].a, result[1].a);
            Assert.AreEqual(expected[1].b, result[1].b);
        }

        [TestMethod]
        public void SqrtNegativeTest()
        {
            double x = -36;

            //array with results
            Complex[] result = { new Complex(), new Complex() };

            //array with expected values
            Complex[] expected = { new Complex(), new Complex() };

            //each element of array is complex number,
            //which has two components - a and b
            expected[0].a = 0.0;
            expected[0].b = 6.0;

            expected[1].a = 0.0;
            expected[1].b = -6.0;

            Calculator Calc = new Calculator();

            result = Calc.Sqrt(x);

            //Compare each component of each results (array of two elemets)
            Assert.AreEqual(expected[0].a, result[0].a);
            Assert.AreEqual(expected[0].b, result[0].b);

            Assert.AreEqual(expected[1].a, result[1].a);
            Assert.AreEqual(expected[1].b, result[1].b);
        }


    }
}
