using System;
using System.Collections.Generic;
using Calculator.Interfaces;

namespace Calculator.Numbers
{
    public class StringNumbersSplitter : IStringNumbersSplitter
    {
        private const string CustomDelimiterIndicator = "##";
        private const char NewlineSeparator = '\n';
        private const char CommaSeparator = ',';
        private const char OpenFlagIndicator = '<';
        private const int StartOfString = 0;
        private const int StartOfDelimiter = 1;


        private IDelimiterExtracter _delimiterExtracter;
        private IStringConverter _converter;

        public StringNumbersSplitter(IDelimiterExtracter delimiterExtracter, IStringConverter converter)
        {
            _delimiterExtracter = delimiterExtracter;
            _converter = converter;
        }

        public IEnumerable<int> SplitStringNumbersOnDelimiter(string numbers)
        {
            var numbersAndCharacters = numbers.Split(NewlineSeparator);
            var characters = numbersAndCharacters[StartOfString];

            if (numbers.StartsWith(CustomDelimiterIndicator) || numbers.StartsWith(OpenFlagIndicator))
            {
                var delimiters = _delimiterExtracter.ExtractDelimiters(characters);
                var numbersWithDelimiters = numbersAndCharacters[StartOfDelimiter];
                
                return _converter.ConvertStringsToNumbers(numbersWithDelimiters.Split(delimiters, StringSplitOptions.RemoveEmptyEntries));
            }

            return _converter.ConvertStringsToNumbers(numbers.Split(new char[] { CommaSeparator, NewlineSeparator}, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}