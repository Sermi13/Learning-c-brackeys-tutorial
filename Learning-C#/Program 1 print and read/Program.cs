using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
          //  Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine("Hello what's your name?");
            name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name} <3");
            Console.ReadKey();
        }
    }
}
