using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            double result = 0;
            if(operation.Contains('+'))
            {
                string[] numbers = operation.Split('+');
                foreach (var number in numbers)
                {
                    result += Convert.ToDouble(number);
                }
                return result;
            }
            return result;
        }
    }
}