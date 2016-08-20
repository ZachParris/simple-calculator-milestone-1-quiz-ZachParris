using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool calculatorOn = true;

            while (calculatorOn)
            {
                string prompt = "[" + counter + "]" + ">";
                Console.Write(prompt);
                counter++;
                string userInput = Console.ReadLine();
                Expression newExp2 = new Expression();
                newExp2.Parser(userInput);
                Evaluation newEva = new Evaluation();
                newEva.Evaluator(newExp2.term_1, newExp2.term_2, newExp2._operator);
                Console.WriteLine("=" + newEva.answer);
            }
            calculatorOn = false;
        }
    }
}
