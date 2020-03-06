using System;

namespace Final_Michael_Yearsley
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problem1:prints your name three times using the for loop, 
             * then prints your name three times using While loop.*/
            Console.WriteLine("Problem1: For Loop");
            Problem1("Michael Yearsley");

            Problem2("Michael", "Yearsley");

            int[] num1;
            Problem3(num1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            int[] num2;
            Problem3(num2 = new int[] { 0, 8, 2, 3, 7, 5, 6, 4, 1, 9 });
            int[] num3;
            Problem3(num3 = new int[] { 0, 1, 2, 3, 5, 4, 6, 7, 8, 9 });
            int[] num4;
            Problem3(num4 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            Console.WriteLine("\nProblem4: sum of the two lowest positive");
            long[] num5;
            Problem4(num5 = new long[] { 19, 5, 42, 2, 77 });
            long[] num6;
            Problem4(num6 = new long[] { 10, 343445353, 3453445, 3453545353453 });
            long[] num7;
            Problem4(num7 = new long[] { 2, 9, 6, -1 });
            long[] num8;
            Problem4(num8 = new long[] { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 });
        }
        public static void Problem1(string name)
        {
            
            
            //For loop loops through printing the name 3 times
            for (int i = 0; i < 3; i++)
            {
                //prints name
                Console.WriteLine(name);

            }
            // used to stop the while loop 
            int j = 0;
            Console.WriteLine("\nProblem1: While Loop");
            //while loop loops through printing the name 3 times
            while (j < 3)
            {
                //prints name
                Console.WriteLine(name);
                j++;
            }
        }
        public static void Problem2(string FirstName, String LastName)
        {
            //Starts a new name with two varriable firstname and lastname
            string[] name = new string[] { FirstName, LastName };
            Console.WriteLine("\nProblem2: Array");
            /*For loop loops through printing the last name first 
             * and the first name last*/
            for (int i = name.Length-1; i >= 0; i--)
            {
                //prints name
                Console.WriteLine(name[i]);

            }
            Console.WriteLine("\nProblem3: sorting numbers");
        }
        public static void Problem3(int[] arr)
        {
            Console.WriteLine("Give me ten numbers");
            //used to hold a temprary value
            int temp = 0;
            /*For loop loops through switching the smaller number with the 
             * larger number to create a sorted list of ints*/
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j =i + 1; j < arr.Length; j++)
                {
                    // compares i in the array to j in the array
                    if (arr[i] > arr[j]) 
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }                
            }
            /*Foreach used to loop through and prints the number*/
            foreach (int item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public static void Problem4(long[] arr)
        {
            
            //used to hold a temprary value
            long temp = 0;
            /*For loop loops through switching the smaller number with the 
             * larger number to create a sorted list of ints*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // compares i in the array to j in the array
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            //loops throught adds up to lowest postive number
            int count = 0;
            int sum = 0;
            foreach (int item in arr)
            {
                if (item > 0 && count < 2 )
                {
                    sum = sum + item;
                    count++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
