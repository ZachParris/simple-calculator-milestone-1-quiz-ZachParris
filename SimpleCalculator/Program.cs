using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            bool calculatorOn = true;
            Stack getLast = new Stack();
            Expression newExp2 = new Expression();

            while (calculatorOn)
            {
                //outputs "[0]>" prompt that will count each command.
                string prompt = "[" + counter + "]>";
                Console.Write(prompt);
                counter++;

                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "lastq":
                        Console.WriteLine(getLast.lastInput); ;
                        break;
                    case "last":
                        Console.WriteLine(getLast.lastResult);
                        break;
                    case "quit":
                        calculatorOn = false; 
                        break;
                    case "exit":
                        calculatorOn = false;
                        break;
                    default:
                        try
                        {
                            newExp2.Parser(userInput);
                            getLast.lastInput = userInput;
                            Evaluation newEva = new Evaluation();
                            newEva.Evaluator(newExp2.term_1, newExp2.term_2, newExp2._operator);
                            getLast.lastResult = newEva.answer;
                            Console.WriteLine("=" + newEva.answer);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                } 
            }
        }
    }
}
