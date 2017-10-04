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
            const string singleMode = "Single";
            const string commaDelimited = "CommaDelimited";
            const string spaceDelimited = "SpaceDelimited";

            Console.WriteLine($"Enter mode: '{singleMode}', '{commaDelimited}', '{spaceDelimited}'");
            var mode = Console.ReadLine();

            Console.WriteLine("Enter value");
            var input = Console.ReadLine();

            var sum = 0;
            var max = 0;

            if (mode == singleMode)
            {
                sum = int.Parse(input);
                max = sum;
            }
            else
            {
                char split;
                if (mode == commaDelimited)
                    split = ',';
                else
                    split = ' ';

                var inputParts = input.Split(split);
                foreach (var part in inputParts)
                {
                    int value = int.Parse(part);
                    sum += value;
                    if (value > max)
                    {
                        max = value;
                    }
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

        /* 3a:
         * Anställda: Kan förändras, nya anställs eller gamla avskedas. Innehåller mer information än Namn och värde
         * Adresser: Innehåller typiskt fler fält än endast namn, där varje enskild del är intressant i sig själv.
         * Pris på kaffe: Värdet skulle gärna vara en float/decimal, men enums representeras av heltal.
         * 
         * 3b: 
         * Ljudinställning på mobilen: Ljud, Tyst, Vibration
         * Status på användare: Aktiv, Inaktiv, Borttagen, Blockerad
         */

        /* 4a:
         * Det är enklare att lagra ett heltal i databas/xml/json än en array
         */
    }
}
