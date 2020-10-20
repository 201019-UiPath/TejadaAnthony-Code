using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   
            string name;
            Console.WriteLine("Enter Name: ");
            
            name = Console.ReadLine();

            Console.WriteLine($"Hello there {name}");
        }
    }
}
