using System.Collections.Generic;

namespace Calculator
{
    public interface IStringToIntConversion
    {
        List<int> GetNumbers(string numbers , string[] delimiters);
    }
}