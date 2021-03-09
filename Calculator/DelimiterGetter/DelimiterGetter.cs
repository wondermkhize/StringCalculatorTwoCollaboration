using System;

namespace Calculator
{
    public class DelimiterGetter : IDelimiterGetter
    {     
        const string hashDelimiter = "##";
        const string commaDelimiter = ",";
        const string newLineDelimiter = "\n";
        const string openingDelimiter = "[";
        const string openCloseDelim = "][";
        const string endFlag = ">";
        const string doubleOpeningBraces = "((";
        public string[] GetDelimiters(string numbers)
        {
            if (!numbers.StartsWith(hashDelimiter))
            {
                return new string[] { commaDelimiter, newLineDelimiter };
            }
            int delimiterLength = numbers.IndexOf(newLineDelimiter) - 2;
            var delimiterData = numbers.Substring(2, delimiterLength);
            if (delimiterData.Contains(openingDelimiter))
            {
                delimiterData = delimiterData.Substring(1, delimiterData.Length - 2);
                return delimiterData.Split(new string[] { openCloseDelim }, StringSplitOptions.RemoveEmptyEntries);
            }
            else if (delimiterData.Contains(endFlag))
            {
                delimiterData = delimiterData.Substring(1, delimiterData.Length - 2);
                return delimiterData.Split(new string[] { doubleOpeningBraces }, StringSplitOptions.RemoveEmptyEntries);
            }

            return new string[] { delimiterData };
        }
    }
}
