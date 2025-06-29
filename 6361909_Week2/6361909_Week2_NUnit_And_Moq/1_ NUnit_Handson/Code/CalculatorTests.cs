using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Teardown()
        {
            _calculator = null;
        }

        [TestCase(5, 3, 8)]
        [TestCase(-2, -4, -6)]
        [TestCase(0, 0, 0)]
        public void Addition_ReturnsExpectedResult(double a, double b, double expected)
        {
            var result = _calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
