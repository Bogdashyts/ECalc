using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECalculator.Models;

namespace ECalculator.Tests
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void TestSum()
        {
            var sumresult = new CalcModel();

            sumresult.Operand1 = 2;
            sumresult.Operand2 = 3;
            sumresult.Operation = CalcOperations.Sum;

            Assert.AreEqual(5, sumresult.Calculate());
        }

        [TestMethod]
        public void TestFactorial() 
        {
            var factorial = new CalcModel();
            factorial.Operand1 = 4;
            factorial.Operation = CalcOperations.Factorial;

            Assert.AreEqual(24, factorial.Calculate());
        }

        [TestMethod]
        public void Devide() 
        {
            var devide = new CalcModel();
            devide.Operand1 = 1;
            devide.Operand2 = 0;
            devide.Operation = CalcOperations.Devide;

            Assert.IsNull(devide.Calculate());
        }
    }
}
