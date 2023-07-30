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
            Console.WriteLine("Enter a string: ");
            string inputstring = Console.ReadLine();

            string vowelCount = CountVowels(inputString);
            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
            Console.ReadKey();

        }
        static int vowelCounts(string inputString)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                char lowercaseChar = char.ToLower(c);
                if(lowercaseChar == 'a' || lowercaseChar == 'e' || lowercaseChar == 'i' || lowercaseChar == 'o' || lowercaseChar == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
