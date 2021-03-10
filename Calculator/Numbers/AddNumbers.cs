using System.Collections.Generic;
using System.Linq;
using Calculator.Interfaces;

namespace Calculator.Numbers
{
    public class AddNumbers : IAddNumbers
    {
        public int Sum(IEnumerable<int> positiveNumbers)
        {
            return (positiveNumbers.Sum() * -1);
        }
    }
}