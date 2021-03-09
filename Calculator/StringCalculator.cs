using System;

namespace Calculator
{
    public class StringCalculator : ICalculator
    {
        private readonly IDelimiterGetter _delimiter;
        private readonly IStringToIntConversion _parser;
        private readonly ISumOfNumbersLessThanMax _theSum;

        public StringCalculator(IDelimiterGetter _delimiter,IStringToIntConversion _parser,ISumOfNumbersLessThanMax _theSum)
        {
          this._delimiter = _delimiter;
          this._parser = _parser;
          this._theSum = _theSum;   
        }
        
        public int Subtract(string numbers)
        {
            var sum = GetTheSumOfNumbers(numbers);

            return sum * -1;
        }

        private int GetTheSumOfNumbers(string numbers)
        {
            var delimiters = _delimiter.GetDelimiters(numbers);
            var parsedNumbers = _parser.GetNumbers(numbers, delimiters);

            return _theSum.GetSumOfNumbers(parsedNumbers);
        }
    }
}
