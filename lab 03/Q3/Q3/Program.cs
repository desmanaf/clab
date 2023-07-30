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
            Console.WriteLine("Enter the number: ");
            string numb = Console.ReadLine();

            if(int.TryParse(numb, out int number))
            {
                int sum = GetSumOfDigits(number);
                Console.WriteLine($"Sum of the digits of {number} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
        static int GetSumOfDigits(int number)
        {
            int sum = 0;
            int numb = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}
