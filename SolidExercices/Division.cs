using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Division : IOperation
    {
        public bool CanCalculate(string calcul)
        {
            return calcul.Contains('/');
        }

        public decimal Calculate(string calcul)
        {
            string[] numbers = calcul.Split('/');
            var result = Convert.ToDecimal(numbers[0]);
            foreach (var number in numbers.Skip(1).ToArray())
            {
                result = result / Convert.ToDecimal(number);
            }
            return result;
        }
    }
}
