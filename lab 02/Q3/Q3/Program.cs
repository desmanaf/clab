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
            Console.Write("Enter the radius: ");
            string radiusinput = Console.ReadLine();

            if (double.TryParse(radiusinput, out double radius))
            {
                double area = radius * radius * Math.PI;
                double circumference = 2 * radius * Math.PI;

                Console.WriteLine("Area of the circle: " + area);
                Console.WriteLine("Circumference of the cicle: " + circumference);


            }
            else
            {
                Console.WriteLine("Enter valid inputs");

            }
            Console.ReadKey();
        }
    }
}
