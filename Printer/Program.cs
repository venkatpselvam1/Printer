using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\nI am venkatesan.");
            while (true)
            {
                Console.WriteLine("enter you name here");
                var name = Console.ReadLine();
                Console.WriteLine($"the name that you entered is {name}");
            }
        }
    }
}
