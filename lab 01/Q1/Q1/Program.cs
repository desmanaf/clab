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
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Batch: ");
            string batch = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your batch is " + batch);

            Console.ReadKey();
        }
    }
}
