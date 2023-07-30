using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the salary: ");
            string empsalary = Console.ReadLine();

            Console.Write("Enter the Tax rate: ");
            string taxrate = Console.ReadLine();
            
            if(double.TryParse(empsalary,out double salary) && double.TryParse(taxrate, out double tax))
            {
                double taxAmount = salary * tax;
                double salaryAfterTax = salary - taxAmount;

                Console.WriteLine("Your salary after tax is: " + salaryAfterTax);


            }
            else
            {
                Console.WriteLine("Your inputs are invalid, Pleasse enter the correct values");
            }
            Console.ReadKey();

        }
    }
}
