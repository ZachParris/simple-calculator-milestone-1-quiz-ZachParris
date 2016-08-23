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
        public int ConstVal;

        private Dictionary<string, int> constantsList = new Dictionary<string, int>();

        public bool CheckForConstValue(string key)
        {
            return constantsList.ContainsKey(key);
        }

        public void AddConstantsToDictionary(string key, int value)
        {
            if (!CheckForConstValue(key))
            {
                constantsList.Add(key, value);
            }
            else
            {
                throw new ArgumentException("Already stored variable.");
            }
        }

        public int GetConstant(string key)
        {
            if (CheckForConstValue(key))
            {
                return constantsList[key];
            }
            throw new ArgumentException($"Constant '{key}' has not been stored yet");
        }
    }
}
