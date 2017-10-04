using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum Modes
    {
        Single,
        CommaDelimited,
        SpaceDelimited
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("You are granted 10 calculations. Enjoy.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter mode: '{Modes.Single}', '{Modes.CommaDelimited}', '{Modes.SpaceDelimited}'");

                string modeString = Console.ReadLine();
                if (modeString == "quit")
                    break;

                Enum.TryParse<Modes>(modeString, out var mode);

                Console.WriteLine("Enter value");
                var input = Console.ReadLine();

                var sum = 0;
                var max = 0;

                switch (mode)
                {
                    case Modes.Single:
                        sum = int.Parse(input);
                        max = sum;
                        break;
                    case Modes.CommaDelimited:
                        foreach (var part in input.Split(','))
                        {
                            int value = int.Parse(part);
                            sum += value;
                            if (value > max)
                            {
                                max = value;
                            }
                        }
                        break;
                    case Modes.SpaceDelimited:
                        foreach (var part in input.Split(' '))
                        {
                            int value = int.Parse(part);
                            sum += value;
                            if (value > max)
                            {
                                max = value;
                            }
                        }
                        break;
                    default:
                        break;
                }

                decimal fraction = max / (decimal)sum;
                Console.WriteLine($@"Inmatat: {sum}
Roten ur: {Math.Sqrt(sum)}
Upphöjt: {Math.Pow(sum, 2)}
Max: {max}
Procent: {fraction.ToString("P")}");
                

                Console.WriteLine(i + 1 + " Calculations done.");
            }
            
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
