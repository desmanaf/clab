using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string firstnum = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string secondnum = Console.ReadLine();

            if(double.TryParse(firstnum, out double value1) && double.TryParse(secondnum, out double value2))
            {
                double sum = value1 + value2;
                Console.WriteLine("Sum is: " + sum);

            }
            else
            {
                Console.WriteLine("Invalid input. Try again");
            }
            Console.ReadKey();

        }
    }
}
