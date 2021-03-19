using System;

namespace Progeam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("PLease Insert 5$ to get a ticket");
            int Cash = Convert.ToInt16(Console.ReadLine());
            if (Cash == 5 )
            {
                Console.WriteLine("Thanks for buying you ticket <3");
            }
            else if (Cash > 5)
            {
                int change = Cash-5;
                Console.WriteLine("Here is your ticked and your " + change + "$");
            }
            else
            {
                Console.WriteLine("Sorry but I can't give credit, come back when you're a little hmmmm~  richer!~");
            }
            Console.ReadLine();
            
        }
    }
}
