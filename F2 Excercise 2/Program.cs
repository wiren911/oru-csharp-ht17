using System;

namespace F2_Excercise_2
{
    class Program
    {
        /// <summary>
        /// Skapa en enkel kalkylator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Let me calculate something.");

            var sum = int.Parse(Console.ReadLine());
            var i = 0;
            while (i < 3)
            {
                var operatorString = Console.ReadLine();
                var input2 = int.Parse(Console.ReadLine());

                switch (operatorString)
                {
                    case "+":
                        sum += input2;
                        break;
                    case "-":
                        sum -= input2;
                        break;
                    case "*":
                        sum *= input2;
                        break;
                    case "/":
                        sum /= input2;
                        break;

                    default:
                        Console.WriteLine("Använd bara + eller -");
                        break;
                }

                Console.WriteLine(sum);
                i++;
            }

            Console.ReadKey();
        }
    }
}
