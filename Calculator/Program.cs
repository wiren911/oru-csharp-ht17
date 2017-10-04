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
            var max = 0;
            foreach (var part in inputParts)
            {
                int value = int.Parse(part);
                sum += value;
                if(value > max)
                {
                    max = value;
                }
            }

            decimal fraction = max / (decimal)sum;
            Console.WriteLine($@"Inmatat: {sum}
Roten ur: {Math.Sqrt(sum)}
Upphöjt: {Math.Pow(sum, 2)}
Max: {max}
Procent: {fraction.ToString("P")}");
            Console.ReadKey();
        }
    }
}
