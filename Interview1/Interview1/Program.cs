using System;
using System.Collections;
using System.Collections.Generic;

namespace Interview1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 0, 0, 0, 25, 25, 25, 7, 5, 6, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 44, 33, 22, 22, 3, 4, 4, 1, 8, 9, 6 };
            RLE(arr);
        }
        public static void RLE(int[] num)
        {
            List<int> NewRLE = new List<int>();
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                
                if (i == 0)
                {
                    count++;
                }
                else if (i == num.Length-1 && num[i] != num[i - 1])
                {
                    NewRLE.Add(1);
                    NewRLE.Add(num[i]);
                }
                else if (num[i] == num[i - 1])
                {
                    count++;
                  
                }
                else if (num[i] != num[i - 1])
                {
                    NewRLE.Add(count);
                    NewRLE.Add(num[i - 1]);
                    count = 1;
                }
            }
            Console.WriteLine(String.Join(",", NewRLE));

        }
    }
}
