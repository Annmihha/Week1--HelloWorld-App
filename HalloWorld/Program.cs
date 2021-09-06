using System;

namespace HalloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserName;
            UserName = Console.ReadLine();

            Console.WriteLine("Hello," + UserName);

            Console.Read();
        }
    }
}
