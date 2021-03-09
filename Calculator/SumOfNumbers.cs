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
            parser
                .Where(num => num <= maxNumber)
                .ToList()
                .ForEach (number => {sum += number;});

             return sum;   
               
        }
    }
}