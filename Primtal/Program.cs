using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = int.Parse(Console.ReadLine());

            for (decimal i = 2; i < max; i++)
            {
                var isPrime = true;
                for (decimal j = 2; j < i; j++)
                {
                    var rest = i % j;
                    if (rest == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime == true)
                    Console.WriteLine(i + " är ett primtal");
            }

            Console.ReadKey();
        }
    }
}
