using Q3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    static class ArrayHelper
    {
        public static int FindMinimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static double FindAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[j] = arr[i];
                j--;
            }
            return reversedArr;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];


            Console.WriteLine("Enter 10 integer values for the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    arr[i] = value;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer value.");
                    return;
                }
            }

            int min = ArrayHelper.FindMinimum(arr);
            Console.WriteLine($"Minimum value: {min}");

            int max = ArrayHelper.FindMaximum(arr);
            Console.WriteLine($"Maximum value: {max}");

            double average = ArrayHelper.FindAverage(arr);
            Console.WriteLine($"Average value: {average}");

            int[] reversedArr = ArrayHelper.ReverseArray(arr);
            Console.WriteLine("Reversed array:");
            foreach (int value in reversedArr)
            {
                Console.Write($"{value} ");
            }
            Console.ReadKey();
        }
    }

}

