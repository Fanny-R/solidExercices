using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5-2,3");
            Check.That(result).IsEqualTo(2.7);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5/2");
            Check.That(result).IsEqualTo(2.5);
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
            var result = calculator.Calculate("8+2+6,3+10");
            Check.That(result).IsEqualTo(26.3);
        }
    }
}
