using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IStringConverter
    {
         IEnumerable<int> ConvertStringsToNumbers(string[] stringNumbers);
    }
}