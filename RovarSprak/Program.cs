using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RovarSprak
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var vocals = new[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            var output = "";
            foreach (char c in input)
            {
                if (vocals.Contains(c) == false)
                    output += $"{c}o{c}";                
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
