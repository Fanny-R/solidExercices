﻿using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly string[] _operations = new[]
            {"1+2,3", "2 x 3,6", "6-1-3,8", "6,6/3", "6/0", "not an operation", "a+1", "12", ""};

        public void Run()
        {
            var operations = new List<IOperation> {new Sum(), new Substraction(), new Division(), new Multiplication()};
            var calculator = new Calculator(operations);
            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }
    }
}
