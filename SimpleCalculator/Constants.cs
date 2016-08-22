using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    public class Constants
    {
        public string ConstVar; 
        public string ConstVal;
        string reqRegex = @"^(?<Variable>[a-z])\s?[=]\s?(?<ConstantValue>-?\d+)$";

        Dictionary<string, int> constantsList = new Dictionary<string, int>();

        public void ParseConstants(string input)
        {
            Match match = Regex.Match(input, reqRegex);
            if (match.Success)
            {
                ConstVar = (match.Groups["ConstVar"].Value);
                ConstVal = (match.Groups["ConstVal"].Value); 
            }
            else
            {
                throw new InvalidOperationException("The requested operation cannot be performed.");
            }
        }

        public void AddConstantsToDictionary(string key, int value)
        {
            constantsList.Add(key, value);
        }

        public bool CheckForConstValue(string key)
        {
            if (constantsList.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
    }
}
