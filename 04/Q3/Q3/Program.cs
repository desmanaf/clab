using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value in kilometers (km): ");
            if (double.TryParse(Console.ReadLine(), out double kmValue))
            {
                ConvertValues converter = new ConvertValues();
                double meterValue = converter.KilometerToMeter(kmValue);
                Console.WriteLine($"{kmValue} kilometers is equal to {meterValue} meters.");
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
        public double KilometerToMeter(double km)
        {
            double meter = km * 1000;
            return meter;
        }
    }
    
    
}
