using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number; ");
            string numb = Console.ReadLine();

            if (double.TryParse(numb,out double num))
            {
                if(num % 2 ==0)
                {
                    Console.WriteLine("It is an even number");
                }
                else
                {
                    Console.WriteLine("It is an odd number");
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
        }
    }
}
