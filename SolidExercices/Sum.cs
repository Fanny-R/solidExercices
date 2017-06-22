﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Sum : IOperation
    {
        public bool CanCalculate(string calcul)
        {
            return calcul.Contains('+');
        }

        public decimal Calculate(string calcul)
        {
            try
            {
                string[] numbers = calcul.Split('+');
                var result = Convert.ToDecimal(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result += Convert.ToDecimal(number);
                }
                return result;
            }
            catch (ArgumentOutOfRangeException e) { }

        }
    }
}
