using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter Number2: ");
            string num2 = Console.ReadLine();

            if (double.TryParse(num1, out double value1) && double.TryParse(num2, out double value2)) 
            {
                double sum = value1 + value2;
                double sub = value1 - value2;
                double div = value1 / value2;
                double mul = value1 * value2;

                Console.WriteLine("Sum value is: " + sum);
                Console.WriteLine("Subtraction value is: " + sub);
                Console.WriteLine("Division value is: " + div);
                Console.WriteLine("Multiplication is: " + mul);

            }
            else
            {
                Console.WriteLine("Invalid value");

            }
            Console.ReadKey();

        }
    }
}
