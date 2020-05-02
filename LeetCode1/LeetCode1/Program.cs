using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LeetCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 2, 7, 11, 15 };
            Console.WriteLine(String.Join(",", TwoSum(Arr, 9)));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] newArr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    else if( nums[i] + nums[j] == target)
                    {
                        newArr[0] = i;
                        newArr[1] = j;
                    }
                }
            }
            return newArr;
        }
    }
}
