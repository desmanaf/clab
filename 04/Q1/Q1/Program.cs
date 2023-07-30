using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value in kilometers (km): ");
            if (double.TryParse(Console.ReadLine(), out double kmValue))
            {
                ConvertValues converter = new ConvertValues();
                converter.KilometerToMeter(kmValue);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid numeric value.");
            }
            Console.ReadKey();
        }
    }

    class ConvertValues
    {
        public void KilometerToMeter(double km)
        {
            double meter = km * 1000;
            Console.WriteLine($"{km} kilometers is equal to {meter} meters.");
        }
    }
}
