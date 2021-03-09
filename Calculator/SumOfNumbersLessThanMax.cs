using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class SumOfNumbersLessThanMax : ISumOfNumbersLessThanMax
    {
        const int maxNumber = 1000;
        public int GetSumOfNumbers(List<int> parser)
        {
            int sum = 0;

            ReturnExceptionMessageInNumbersBiggerThanMaxNumber(parser);
            
            parser
                .Where(num => num <= maxNumber)
                .ToList()
                .ForEach (number => {sum += number;});

             return sum;   
               
        }

        private void ReturnExceptionMessageInNumbersBiggerThanMaxNumber(List<int> parsedNumbers)
        {
            var numbersAboveMaxNumber = new List<int>();
            parsedNumbers
                .Where(num => num > maxNumber)
                .ToList()
                .ForEach(number => {numbersAboveMaxNumber.Add(number);});

            if(numbersAboveMaxNumber.Any())
            {
                throw new System.Exception("Numbers bigger than 1000 :" + string.Join(",",numbersAboveMaxNumber));
            }
        }
    }
}