using System;
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
         
            PrintGrid(a);
            
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

        private static void PrintGrid(int[,] a)
        {
            for (int j = 0; j < a.GetLength(0); j++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    Console.Write(a[j, k]);
                }
                Console.WriteLine();
            }
        }

    }
}
