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
            Console.Write("Enter Number1: ");
            string numb1 = Console.ReadLine();

            Console.Write("Enter Number2: ");
            string numb2 = Console.ReadLine();

            if(double.TryParse(numb1, out double number1) && double.TryParse(numb2, out double number2))
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.Write("Enter Your Choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4 )
                {
                    double result = 0;

                    switch(choice)
                    {
                        case 1:
                            result = number1 + number2;
                            break;

                        case 2:
                            result = number1 - number2;
                            break;

                        case 3:
                            result = number1 / number2;
                            break;

                        case 4:
                            if (number2 != 0)
                                result = number1 / number2;

                            else
                            {
                                Console.WriteLine("Error");
                                break;

                            }
                        break;

                        
                    }
                    if (choice >= 1 && choice <= 4 && choice != 4)
                        Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid numeric values for the two numbers.");
            }
            Console.ReadKey();

        }
    }
}
