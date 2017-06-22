using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Sum : IOperation
    {
        public bool CanCalculate(string operation)
        {
            return operation.Contains('+');
        }

        public decimal Calculate(string operation)
        {
            string[] numbers = operation.Split('+');
            var result = Convert.ToDecimal(numbers[0]);
            foreach (var number in numbers.Skip(1).ToArray())
            {
                result += Convert.ToDecimal(number);
            }
            return result;
        }
    }
}
