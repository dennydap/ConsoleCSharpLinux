using System;

namespace ConsoleCSharpLinux
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is for testing purpose.");
            Console.WriteLine("Please tell me your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("\n\nHello, " + name);
            Console.WriteLine("For your info, this solution was being made in Linux using MonoDevelop.");
            Console.WriteLine("Have a nice day!");
        }
    }
}
