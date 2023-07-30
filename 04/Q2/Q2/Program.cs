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
            Console.Write("Enter the value in Kilometers (Km): ");
            if (double.TryParse(Console.ReadLine(), out double kmValue))
            {
                ConvertValues converter = new ConvertValues();
                converter.KilometerToMeter(kmValue);
            }
            else
            {
                Console.WriteLine("Invalid Input, Try again");

            }
            Console.ReadKey();

        }
    }
    class ConvertValues
    {
        public void KilometerToMeter(double km)
        {
            double meter = km * 1000;
            Console.WriteLine($"{km} kilometer is equel to {meter} meters.");
        }
    }
}
