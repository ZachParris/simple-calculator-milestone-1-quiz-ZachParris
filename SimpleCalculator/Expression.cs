using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        public int term_1 { get; set; }
        public int term_2 { get; set; }
        public char _operator { get; set; }
        string regex_match = @"^(\d)(\s*)(\+|\-|\*|\%\/)(\s*)(\d)$";
        public bool invalidEntry { get; set; }

        public void Parser (string input)
        {
            try
            {
                Match match = Regex.Match(input, regex_match);

                if (match.Success)
                {
                    term_1 = int.Parse(match.Groups[1].Value);
                    _operator = char.Parse(match.Groups[2].Value);
                    term_2 = int.Parse(match.Groups[3].Value);

                }
                else
                {
                    throw new InvalidOperationException("Try a 2 term expression");
                }
            }
            catch (InvalidOperationException)
            {
                invalidEntry = true;
            }
        }


    }
}
