using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [DataRow(17, 13, 30)]
        [DataRow(20, 1.3, 21.3)]
        [DataRow(20, -5, 15)]
        public void AddTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            result = Calc.Add(x,y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(100,10, 90)]
        [DataRow(20, 0, 20)]
        [DataRow(20, -5, 25)]
        public void SubstructionTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            result = Calc.Substruction(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 10, 50)]
        [DataRow(3.3, 3.0, 9.90)]
        [DataRow(20, -5, -100)]
        [DataRow(20, 0, 0)]
        public void MultiplicationTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            result = Calc.Multiplication(x, y);
            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        [DataRow(22, 4, 5.5)]
        [DataRow(0, 5, 0)]
        [DataRow(20, -5, -4)]
        [DataRow(20, 0.0, double.NaN)]
        public void DivisionTest(double x, double y, double expected)
        {
            double result;
            Calculator Calc = new Calculator();

            result = Calc.Division(x, y);
            Assert.AreEqual(expected, result);
        }

    }
}
