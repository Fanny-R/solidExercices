using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            IOperation sum = new Sum();
            IOperation substraction = new Substraction();
            IOperation division = new Division();
            IOperation multiplication = new Multiplication();
            if (sum.CanCalculate(operation))
            {
                return sum.Calculate(operation);
            }
            if (substraction.CanCalculate(operation))
            {
                return substraction.Calculate(operation);
            }
            if (division.CanCalculate(operation))
            {
                return division.Calculate(operation);
            }
            if (multiplication.CanCalculate(operation))
            {
                return multiplication.Calculate(operation);
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}