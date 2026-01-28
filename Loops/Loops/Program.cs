using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();
            int first = Convert.ToInt32(firstInput);

            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();
            int Second = Convert.ToInt32(secondInput);
            Console.WriteLine();

            var answer = first * Second;
            var actualAnswer = 0;

            while (answer != actualAnswer)
            {
                Console.WriteLine("Whats the value of " + first + "*" + Second + " ?");
                Console.Write("enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("your answer is wrong");
                    Console.WriteLine();
                }
                else 
                {
                    Console.WriteLine("Horee you right");
                }
            }

            //do
            //{
            //    Console.Write("enter your answer: ");
            //    string answerInput = Console.ReadLine();
            //    actualAnswer = Convert.ToInt32(answerInput);

            //    if (answer != actualAnswer)
            //    {
            //        Console.WriteLine("your answer is wrong");
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Horee you right");
            //    }
            //} while (answer != actualAnswer);


            // bonus conditional operator
            // condition ?  true : false

            int age = -10;

            string result = age >= 0 ? "valid" : "invalid";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
