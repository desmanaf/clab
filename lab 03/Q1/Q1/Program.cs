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
            Console.WriteLine("Enter the value: ");
            int numb = int.Parse(Console.ReadLine());

            string result = IsEvenOrOdd(numb);

            Console.WriteLine($"The number {numb} is {result}");
            Console.ReadKey();
        }
        

        static string IsEvenOrOdd(int numb)
        {
            if(numb % 2 == 0)
            {
                return "Even";

            }
            else
            {
                return "Odd";
            }
        }
        
    }
    
}
