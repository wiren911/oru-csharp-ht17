using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputAsInt = int.Parse(input);

            Console.WriteLine("Inmatat: " + inputAsInt + "\r\nRoten ur: " + Math.Sqrt(inputAsInt) + "\r\nUpphöjt: " + Math.Pow(inputAsInt, 2));
            Console.ReadKey();
        }
    }
}
