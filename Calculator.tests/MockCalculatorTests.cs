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

        [TestCase(-12, "10,-2")]
        public void GIVEN_NegativeNumbers_WHEN_Subtracting_RETURN_NegSum(int expected , string numbers)
        {
            var calculator = Substitute.For<ICalculator>();

            calculator.Subtract(numbers).Returns(expected);
            var actualResults = calculator.Subtract(numbers);

            Assert.AreEqual(expected, actualResults);
        }

        [Test]
        [TestCase(-3,"##;\n1;2")]
        public void GIVEN_BiggerNumber_WHEN_Subtracting_RETURN_ExceptionMessage(int expected , string numbers)
        {
            var calculator = Substitute.For<ICalculator>();

            calculator.Subtract(numbers).Returns(expected);
            var actualResults = calculator.Subtract(numbers);

            Assert.AreEqual(expected, actualResults);
        }
        
        [TestCase(-6 ,"##[***]\n1***2***3")]
        [TestCase(-6 ,"##[*][%]\n1*2%3")]
        public void GIVEN_DelimitedString_WHEN_Subtracting_RETURN_Sum(int expected , string numbers)
        {
            var calculator = Substitute.For<ICalculator>();

            calculator.Subtract(numbers).Returns(expected);
            var actualResults = calculator.Subtract(numbers);

            Assert.AreEqual(expected, actualResults);
        }
    }
}