using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            string inputradius = Console.ReadLine();

            if (double.TryParse(inputradius, out double radius))
            {
                double area = radius * radius * Math.PI;
                Console.WriteLine("Area is: " + area);

            }
            else
            {
                Console.WriteLine("Invalid input, Try again");
            }
            Console.ReadKey();
        }
    }
}
