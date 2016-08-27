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
            Expression newExp = new Expression();

            while (calculatorOn)
            {
                string prompt = "[" + counter + "]>";
                Console.Write(prompt);

                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "lastq":
                        Console.WriteLine(getLast.lastInput);
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
                            newExp.Parser(userInput);
                            getLast.lastInput = userInput;
                            Evaluation eval = new Evaluation();
                            getLast.lastResult = eval.answer;

                            if (newExp.storedConstant == true)
                            {
                                Console.WriteLine("Stored Constant");
                            }
                            else
                            {
                                eval.Evaluator(newExp.term_1, newExp.term_2, newExp._operator);
                                Console.WriteLine("=" + eval.answer);
                                
                            }
                            newExp.storedConstant = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
                counter++; 
            }
        }
    }
}
