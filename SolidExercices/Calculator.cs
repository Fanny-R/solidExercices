using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperation> _operations;
        public Calculator(List<IOperation> operations)
        {
            _operations = operations;
        }
        public decimal Calculate(string calcul)
        {
            var operations = new List<IOperation>();
            operations.Add(new Sum());
            operations.Add(new Substraction());
            operations.Add(new Division());
            operations.Add(new Multiplication());

            foreach (var operation in operations)
            {
                if (operation.CanCalculate(calcul))
                {
                    return operation.Calculate(calcul);
                }
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}