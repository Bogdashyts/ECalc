using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECalculator.Models
{
    public enum CalcOperations
    {
        Sum,
        Substract,
        Multiply,
        Devide,
        Factorial,
    }

    public class CalcModel
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public CalcOperations Operation { get; set; }

        public double? Result { get; set; }

        public double? Calculate()
        {
            switch (Operation)
            {
                case CalcOperations.Devide: Result = Devide(Operand1, Operand2);
                    break;
                case CalcOperations.Multiply: Result = Multiply(Operand1, Operand2);
                    break;
                case CalcOperations.Substract: Result = Substract(Operand1, Operand2);
                    break;
                case CalcOperations.Sum: Result = Sum(Operand1, Operand2);
                    break;
                case CalcOperations.Factorial: Result = GetFactorial(Operand1);
                    break;
            }

            return Result;
        }


        private int GetFactorial(int value)
        {
            int result = value;
            value -= 1;
            if (value > 0)
            {
                result *= GetFactorial(value);
            }
            return result;
        }


        private double? Sum(int oper1, int oper2)
        {
            return oper1 + oper2;
        }

        private double? Devide(int oper1, int oper2)
        {
            if (oper2 != 0)
            {
                return (double)oper1 / oper2;
            }
            else
                return null;
        }

        private double? Multiply(int oper1, int oper2)
        {
            return oper1 * oper2;
        }

        private double? Substract(int oper1, int oper2)
        {
            return oper1 - oper2;
        }
    }
}