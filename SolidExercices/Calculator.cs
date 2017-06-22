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
            foreach (var operation in _operations)
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