using System;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Num01;
            Double Num02;
            Console.WriteLine("Insert a number");
            Num01 = Convert.ToDouble(Console.ReadLine());
            Num02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Num01+Num02);
            Console.ReadLine();
        }
    }
}
