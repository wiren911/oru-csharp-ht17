using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2_Excercise_1
{
    class Program
    {
        /// <summary>
        /// 1. Skapa en sträng-ihopslagare
        /// 2. Avsluta om "quit"
        /// 3. Gör om till miniräknare light
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var total = 0;

            var input = "";
            while (input != "quit")
            {
                input = Console.ReadLine();
                var isInt = int.TryParse(input, out var inputAsInt);
                if(isInt)
                    total += inputAsInt;

                Console.WriteLine(total);
            }
        }
    }
}
