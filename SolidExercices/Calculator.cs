﻿using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            if(operation.Contains('+'))
            {
                string[] numbers = operation.Split('+');
                var result = Convert.ToDecimal(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result += Convert.ToDecimal(number);
                }
                return result;

            }
            if (operation.Contains('-'))
            {
                string[] numbers = operation.Split('-');
                var result = Convert.ToDecimal(numbers[0]);
                foreach (var number in numbers.Skip(1).ToArray())
                {
                    result = result - Convert.ToDecimal(number);
                }
                return result;
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
            Console.WriteLine("Opération non prise en charge");
            return 0;
        }
    }
}