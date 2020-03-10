using System;

namespace OOP1
{
    class Program
    {
        public static string title = "C# Essential Training";
        public static int whichpart;
        static void Main(string[] args)
        {
            whichpart = 2;
            var message = string.Format("Welcome to {0} Part {1}!", title, whichpart);
            Console.WriteLine(message);
            Console.WriteLine("Press the enter key to exit.");
            Console.ReadLine();
        }
    }
}
