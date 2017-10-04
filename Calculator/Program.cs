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

            Console.WriteLine($@"Inmatat: {inputAsInt}
Roten ur: {Math.Sqrt(inputAsInt)}
Upphöjt: {Math.Pow(inputAsInt, 2)}");
            Console.ReadKey();
        }
    }
}
