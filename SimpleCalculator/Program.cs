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
                Expression newExp = new Expression();
                Evaluation newEval = new Evaluation();
                newEval.Evaluator(1, 2, "+");
                Console.WriteLine("=" + newEval.answer);
            }
            calculatorOn = false;
        }
    }
}
