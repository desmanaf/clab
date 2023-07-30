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
            Animal animal = new Animal();
            Dog dog = new Dog();

            animal.Display();
            dog.Display();
        }

    }

    class Animal
    {
        public void Display()
        {
            Console.WriteLine("I am an animal");
        }
    }

    class Dog : Animal
    {
        public new void Display()
        {
            base.Display();
            Console.WriteLine("I have four legs");
        }

    }

   
}