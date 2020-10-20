using System;
using HerosLib;

namespace HerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Heros obj = new Heros();

            Console.WriteLine($"My name is {obj.name} id is {obj.id}");
        }
    }
}
