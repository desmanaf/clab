using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number01: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter number2: ");
            string num2 = Console.ReadLine();

            if(double.TryParse(num1, out double value1) && double.TryParse(num2, out double value2))
            {
                double sum = value1 + value2;
                Console.WriteLine("Sum is: " + sum);

            }
            else
            {
                Console.WriteLine("Invalid input, Try again");
            }
            Console.ReadKey();

        }
    }
}
