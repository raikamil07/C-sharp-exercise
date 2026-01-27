using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka = 10;

            angka++;
            //angka--;
            Console.WriteLine(angka);
            
            angka = angka + 2;
            //angka = angka - 2;
            Console.WriteLine(angka);

            angka += 1;
            //angka -= 1;
            Console.WriteLine(angka);

            angka *=4;
            Console.WriteLine(angka);

            angka /=2;
            Console.WriteLine(angka);

            string name = "John";
            name += " is handsome ";
            Console.WriteLine(name); 

            char a = 'A';
            a++;
            a += 'B';
            Console.WriteLine(a);

            //modulus

            int first = 20;
            int second = 6;
            Console.WriteLine(first % second);

            Console.ReadLine();
        }
    }
}
