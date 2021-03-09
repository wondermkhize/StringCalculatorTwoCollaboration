using System.Collections.Generic;

namespace Calculator
{
    public interface INumbersValidator
    {
        List<int> GetAbsoluteNumbers(List<int> parsedNumbers);
    }
}