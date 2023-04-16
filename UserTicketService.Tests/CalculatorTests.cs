using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Substraction_MustReturnCorrectVal()
        {
            var calculator = new Calculator();
            int value = calculator.Subtraction(7, 2);

            Assert.That(value == 5);
        }

        [Test]
        public void Division_MustReturtnCorrectVal()
        {
            var calculator = new Calculator();
            int value = calculator.Division(10, 2);

            Assert.That(value == 5);
        }

        [Test]
        public void Division_MustReturnDivideByZeroEx()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculator = new Calculator();
            var value = calculator.Add(5, 10);
            Assert.That(value, Is.EqualTo(15));
        }
    }
}
