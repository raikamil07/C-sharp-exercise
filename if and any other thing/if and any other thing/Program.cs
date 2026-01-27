using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_and_any_other_thing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.Write("Whats your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Whats your age: ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);

            //Console.WriteLine();
            //Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            //// == > >= < <= !=
            //if (age >= 18 && age <= 25)
            //{
            //    Console.WriteLine("You are between 18 and 25");
            //}
            //else if ( age >= 26)
            //{
            //    Console.WriteLine("Your age more than 26.");
            //}

            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("Your input invalid age!");
            //}

            Console.Write("input the first number: ");
            string firstInput = Console.ReadLine();
            int first = Convert.ToInt32(firstInput);

            Console.Write("input the second number: ");
            string secondInput = Console.ReadLine();
            int second = Convert.ToInt32(secondInput);

            var answer = first * second;

            Console.Write("What is " + first + " multiplied by " + second + "? ");
            string answerInput = Console.ReadLine();
            int answerInputInt = Convert.ToInt32(answerInput);

            if (answer == answerInputInt)
            {
                Console.WriteLine("correct!");
            }
            else
            { 
                Console.WriteLine("Wrong");
            }

            Console.Write("Number of the day: ");
            string dayInput = Console.ReadLine();
            int day = Convert.ToInt32(dayInput);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number!");
                    break;
            }

            Console.Write("Input your message here: ");
            string message = Console.ReadLine();
            Console.Write("How many you want to repeat it: ");
            int loopcounter = Convert.ToInt32(Console.ReadLine());

            if (loopcounter <= 0)
            {
                Console.WriteLine("Invalid number! Use more than 0");
            }
            else 
            {
                for (int i = 0; i < loopcounter; i++)
                {
                    Console.WriteLine(message);
                }
            }
            Console.ReadLine();
        }
    }
}
