using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;
        [SetUp]
        public void Init()
        {
            var operations = new List<IOperation> {new Sum(), new Substraction(), new Division(), new Multiplication()};
            _calculator = new Calculator(operations);
        }

        [Test]
        public void CalculateASum()
        {
            var result = _calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var result = _calculator.Calculate("5-2,3");
            Check.That(result).IsEqualTo(2.7m);
        }

        [Test]
        public void CalculateADivision()
        {
            var result = _calculator.Calculate("5/2");
            Check.That(result).IsEqualTo(2.5m);
        }

        [Test]
        public void CalculateAMultiplication()
        {
            var result = _calculator.Calculate("5*2");
            Check.That(result).IsEqualTo(10);
        }

        [Test]
        public void CalculateASumWithMoreThanTwoOperand()
        {
            var result = _calculator.Calculate("8+2+10+6,5");
            Check.That(result).IsEqualTo(26.5m);
        }

        [Test]
        public void ThrowAnExceptionWhenEmptyOperation()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Calculate(""));
        }
    }
}
