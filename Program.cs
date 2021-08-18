using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's up, what's your name?");
            var name = Console.ReadLine();
            Console.WriteLine(" Hey, " + name + ".");
        }
    }
}
