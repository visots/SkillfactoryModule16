using NUnit.Framework;

namespace FinalTask16_7_1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            var result = calculator.Additional(100,100);
            Assert.That(result == 200);
        }

        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            var result = calculator.Subtraction(100, 100);
            Assert.True(result == 0);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            var result = calculator.Multiplication(5, 5);
            Assert.That(result == 25);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            var result = calculator.Division(25, 5);
            Assert.That(result == 5);
        }
    }
}