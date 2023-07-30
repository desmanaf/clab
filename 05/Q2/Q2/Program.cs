using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                FindValues finder = new FindValues();
                double area = finder.FindArea(radius);
                double circumference = finder.FindCircumference(radius);

                Console.WriteLine($"Area of the circle: {area}");
                Console.WriteLine($"Circumference of the circle: {circumference}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid numeric value for the radius.");
            }
            Console.ReadKey();
        }
    }

    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
   