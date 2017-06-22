using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            if(operation.Contains('+'))
            {
                string[] numbers = operation.Split('+');
                double result = Convert.ToDouble(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result += Convert.ToDouble(number);
                }
                return result;

            }
            else if (operation.Contains('-'))
            {
                string[] numbers = operation.Split('-');
                double result = Convert.ToDouble(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result = result - Convert.ToDouble(number);
                }
                return result;
            }
            else if (operation.Contains('/'))
            {
                string[] numbers = operation.Split('/');
                double result = Convert.ToDouble(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result = result / Convert.ToDouble(number);
                }
                return result;
            }
            else if (operation.Contains('*'))
            {
                string[] numbers = operation.Split('*');
                double result = Convert.ToDouble(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result = result * Convert.ToDouble(number);
                }
                return result;
            }
            else
            {
                Console.WriteLine("Opération non prise en charge");
                return 0;
            }
        }
    }
}