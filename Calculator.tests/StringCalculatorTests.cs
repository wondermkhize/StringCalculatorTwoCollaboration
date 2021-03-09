using NUnit.Framework;

namespace Calculator.tests
{
    public class StringCalculatorTests
    {
        private StringCalculator _calculator;
        
        [SetUp]
        public void Setup()
        {
            _calculator = new StringCalculator();
        }

        [Test]
        public void GIVEN_AnEmptyString_WHEN_Subtracting_RETURNS_ZERO()
        {
            //arrange
            const string numbers = "";
            const int expectedResult = 0;

            //act
            var actualResult = _calculator.Subract(numbers);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}