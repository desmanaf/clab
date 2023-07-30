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
            Console.WriteLine("Enter the radius: ");
            string radiusInput = Console.ReadLine();

            if (double.TryParse(radiusInput, out double radius))
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine("Area of the circle is: " + area);

            }
            else
            {
                Console.WriteLine("Invalid input. Please entetr the valid inputs");


            }
            Console.ReadKey();

        }
    }
}
