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
            var operations = new List<IOperation>();
            operations.Add(new Sum());
            operations.Add(new Substraction());
            operations.Add(new Division());
            operations.Add(new Multiplication());
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
            var calculator = new Calculator();
            var result = calculator.Calculate("5-2,3");
            Check.That(result).IsEqualTo(2.7m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5/2");
            Check.That(result).IsEqualTo(2.5m);
        }

        [Test]
        public void CalculateAMultiplication()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5*2");
            Check.That(result).IsEqualTo(10);
        }

        [Test]
        public void CalculateASumWithMoreThanTwoOperand()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("8+2+10+6,5");
            Check.That(result).IsEqualTo(26.5m);
        }

        [Test]
        public void ThrowAnExceptionWhenIncorrectOperation()
        {
            var calculator = new Calculator();
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Calculate(""));
        }
    }
}
