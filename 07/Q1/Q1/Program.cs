using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    static class ArrayProcessor
    {
        public static int[] ProcessArray(int size)
        {
            int[] arr = new int[size * 2];
            int index = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    arr[index++] = value;
                    arr[index++] = 0;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer value.");
                    return null;
                }
            }

            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                int[] processedArray = ArrayProcessor.ProcessArray(size);

                if (processedArray != null)
                {
                    Console.WriteLine("Processed array values:");
                    foreach (int value in processedArray)
                    {
                        Console.Write($"{value} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid positive integer value for the array size.");
            }
            Console.ReadKey();
        }
    }
}
