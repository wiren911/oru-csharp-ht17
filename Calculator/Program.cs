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

            var inputParts = input.Split(',');

            var sum = 0;
            foreach (var part in inputParts)
            {
                sum += int.Parse(part);
            }

            Console.WriteLine($@"Inmatat: {sum}
Roten ur: {Math.Sqrt(sum)}
Upphöjt: {Math.Pow(sum, 2)}");
            Console.ReadKey();
        }
    }
}
