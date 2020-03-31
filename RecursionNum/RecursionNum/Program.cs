using System;

namespace RecursionNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Separator");
            numSep(231);
            Console.WriteLine("Factorial");
            Console.WriteLine(factorial(3));
        }
        public static void numSep(int num)
        {

            if(num < 10)
            {
                Console.WriteLine(num);
                return;
            }
            numSep(num / 10);
            Console.WriteLine(num % 10);
        }
        public static long factorial(int num)
        {
            if (num < 0)
            {
                throw new Exception(" You can't have a negative");
            }
            else if (num == 0)
            {
                return 1;

            }
            return num * factorial(num - 1);
        }


    }
}
