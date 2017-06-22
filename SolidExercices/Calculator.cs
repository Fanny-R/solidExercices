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
            if (sum.CanCalculate(operation))
            {
                return sum.Calculate(operation);
            }
            if (substraction.CanCalculate(operation))
            {
                return substraction.Calculate(operation);
            }
            if (operation.Contains('/'))
            {
                string[] numbers = operation.Split('/');
                var result = Convert.ToDecimal(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result = result / Convert.ToDecimal(number);
                }
                return result;
            }
            if (operation.Contains('*'))
            {
                string[] numbers = operation.Split('*');
                var result = Convert.ToDecimal(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result = result * Convert.ToDecimal(number);
                }
                return result;
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}