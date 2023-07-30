using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int sum = CalculateSumOfOddNumbers(n);
                Console.WriteLine($"Sum of all odd numbers from 1 to {n} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid positive integer.");
            }
            Console.ReadKey();
        }

        static int CalculateSumOfOddNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
