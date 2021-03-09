using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IStringNumbersSplitter
    {
         IEnumerable<int> SplitStringNumbersOnDelimiter(string numbers);
    }
}