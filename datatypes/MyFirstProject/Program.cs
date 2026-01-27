using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data type number in C#

            int age = 25;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 890000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double price = 19.99D;
            Console.WriteLine(price);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float height = 5.9F;
            Console.WriteLine(height);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal bankBalance = 1000000.50M;
            Console.WriteLine(bankBalance);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            //data type letter in C#
            string firstName = "John";
            char initial = 'J';

            Console.Write("your name is ");
            Console.Write(firstName);
            Console.WriteLine();
            Console.WriteLine(initial);
            Console.WriteLine("hello world!");
            
            //convert text based types
            string umur = "30";
            int umurint = Convert.ToInt32(umur);
            //long umurlong = Convert.ToInt64(umur);
            //double umurdouble = Convert.ToDouble(umur);
            //float umurfloat = Convert.ToSingle(umur);
            //decimal umurdecimal = Convert.ToDecimal(umur);
            Console.WriteLine(umurint);

            //data type boolean in C#
            bool male = true;

            bool isMale = true;
            Console.WriteLine(isMale);
            
            isMale = false;
            Console.WriteLine(isMale);

            // var (implicit typing) in C#
            var city = "New York";
            Console.WriteLine(city);

            var death = 30;
            Console.WriteLine(death);

            //const in C# (constant)

            const int month = 12;
            Console.WriteLine(month);


            //month = 13; // will error because constant value cannot be changed but its doesnt mean we cant use the variable

            const string version = "1.0.0";
            Console.WriteLine(version);

            //version = "1.0.1"; will error because constant value cannot be changed but its doesnt mean we cant use the variable


            Console.ReadLine();
        }
    }
}
