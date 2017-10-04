﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GenerateArray();
            var x = 0;
            var y = 0;
            var sum = 0;


            PrintGrid(a, x, y);
        }

        private static int[,] GenerateArray()
        {
            var a = new int[16, 32];
            var r = new Random();
            for (int j = 0; j < a.GetLength(0); j++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    a[j, k] = r.Next(2);
                }
            }

            return a;
        }

        private static void PrintGrid(int[,] a, int x, int y)
        {
            for (int j = 0; j < a.GetLength(0); j++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    if (x == k && y == j)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                        Console.Write(a[j, k]);
                }
                Console.WriteLine();
            }
        }

    }
}
