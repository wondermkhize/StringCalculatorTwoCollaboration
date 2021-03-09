using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class NumbersValidator : INumbersValidator
    {
        public List<int> GetAbsoluteNumbers(List<int> parsedNumbers)
        {
            return parsedNumbers.Select(number => Math.Abs(number)).ToList();
        }
    }
}