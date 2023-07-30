using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int totalInputs = 10;
            Console.WriteLine($"Enter {totalInputs} Numbers: ");

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine($"Number {i}: ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out int number))
                {
                    if(number %2 ==0)
                    {
                        Console.WriteLine(number + " Is an even number");

                    }
                    else
                    {
                        Console.WriteLine(number + " Is an odd number");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }
            Console.ReadKey();

        }
    }
}
