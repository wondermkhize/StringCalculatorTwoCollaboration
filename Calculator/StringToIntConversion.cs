using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class StringToIntConversion : IStringToIntConversion
    {
        public List<int> GetNumbers(string numbers , string[] delimiters)
       {
             var stringNumber = numbers;
             if(numbers.StartsWith("##"))
             {
                 int startDelim = numbers.IndexOf("\n")+1;
                 stringNumber = numbers.Substring(startDelim);

             }
             return Array.ConvertAll(stringNumber.Split(delimiters,StringSplitOptions.RemoveEmptyEntries),int.Parse).ToList();
       }
    }
  
}