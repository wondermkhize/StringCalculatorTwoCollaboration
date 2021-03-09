using NUnit.Framework;
using NSubstitute;
using Calculator;

namespace Calculator.tests
{
    [TestFixture]
    public class MockCalculatorTests
    {

        [Test]
        [TestCase(-3,"##;\n1;2")]
        public void GIVEN_HashDelimiter_WHEN_Subtracting_RETURN_Sum(int expected , string numbers)
        {
            var calculator = Substitute.For<ICalculator>();

            calculator.Subtract(numbers).Returns(expected);
            var actualResults = calculator.Subtract(numbers);

            Assert.AreEqual(expected, actualResults);
        }
    }
}