using System;

namespace LeeetCode7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1534236469;
            Console.WriteLine(Reverse(num));
            int num1 = -321;
            Console.WriteLine(Reverse(num1));
            int num2 = -1534236469;
            Console.WriteLine(Reverse(num2));
            int num3 = 153;
            Console.WriteLine(Reverse(num3));

        }
        public static int Reverse(int x)
        {
            string num = Convert.ToString(x);
            char[] newNum = new char[num.Length];
            int j = 0;
            if (num[j] == '-')
            {

                for (int i = newNum.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        newNum[0] = '-';
                    }
                    else if (i == newNum.Length - 1)
                    {
                        j++;
                        newNum[j] = num[i];
                        j++;
                    }
                    else
                    {
                        newNum[j] = num[i];
                        j++;
                    }
                }
            }
            else
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {

                    newNum[j] = num[i];
                    j++;
                }
            }
            string str = new string(newNum);
            int Rnum = 0;
            try
            {
                Rnum = Convert.ToInt32(str);
            }
            catch
            {
                return 0;
            }
            return Rnum;
        }

    }
}
