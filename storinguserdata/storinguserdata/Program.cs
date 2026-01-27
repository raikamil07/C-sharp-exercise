using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storinguserdata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // storing user data
            string name = "Raihan Kamil";
            string phonenumber = "081312345678";
            int age = 20;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("PhoneNo: " + phonenumber);
            Console.WriteLine("Age: " + age);

            // odd/even checker
            int first = 100;
            int second = 45;

            Console.WriteLine(first % second);

            first = 90;
            Console.WriteLine(first % second);


            Console.ReadLine();
        }
    }
}
