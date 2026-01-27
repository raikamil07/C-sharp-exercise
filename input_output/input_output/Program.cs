using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.Write("Whats your name: ");
            string name = Console.ReadLine();

            Console.Write("Whats your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            Console.ReadLine();
        }
    }
}
