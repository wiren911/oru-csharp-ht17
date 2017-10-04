﻿using System;
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

        /* 3a:
         * Anställda: Kan förändras, nya anställs eller gamla avskedas. Innehåller mer information än Namn och värde
         * Adresser: Innehåller typiskt fler fält än endast namn, där varje enskild del är intressant i sig själv.
         * Pris på kaffe: Värdet skulle gärna vara en float/decimal, men enums representeras av heltal.
         * 
         * 3b: 
         * Ljudinställning på mobilen: Ljud, Tyst, Vibration
         * Status på användare: Aktiv, Inaktiv, Borttagen, Blockerad
         */
    }
}
