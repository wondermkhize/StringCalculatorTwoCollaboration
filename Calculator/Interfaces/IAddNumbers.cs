using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IAddNumbers
    {
        int Sum(IEnumerable<int> positiveNumbers);
    }
}