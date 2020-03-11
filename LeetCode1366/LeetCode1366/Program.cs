using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LeetCode1366
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string[] arr;
            Console.WriteLine(RankTeams(arr = new string[]{ "ABC", "ACB", "ABC", "ACB", "ACB" }));
        }
        public static string RankTeams(string[] votes)
        {

            List<ConsoleApp1> winner = new List<ConsoleApp1>();
            StringBuilder arr = new StringBuilder();
            Dictionary<char, int> votecount = new Dictionary<char, int>();
            string vote = string.Empty;
            for (int i = 0; i < votes.Length; i++)
            {
                arr.Append(votes[i]);
            }
            string arr2 = Convert.ToString(arr);
            Console.WriteLine(arr);
            int count = 1;
            int value = 0;
            foreach (var item in arr2)
            {

                if (count > votes[0].Length)
                    count = 1;
                if (votecount.ContainsKey(item))
                {
                    value = votecount[item];
                    votecount[item] = value + count;
                }
                else
                {
                    votecount.Add(item, count);
                }
                count++;
            }
            foreach (var i in votecount)
            {
                string word = Convert.ToString(i);
                word = word.Replace("]", "");
                int number = int.Parse(Convert.ToString(word[4]));
                winner.Add(new ConsoleApp1() { Num = number, ABC = word[1] });
            }
            winner.Sort(delegate (ConsoleApp1 x, ConsoleApp1 y)
            {
                if (x.Num == y.Num) return x.Num;
                else if (x.Num == 0) return -1;
                else if (y.Num == 0) return 1;
                else return x.Num.CompareTo(y.Num);
            });
            String results = string.Empty;
            foreach (var item in winner)
            {
                Console.WriteLine($"{item.Num} + {item.ABC}");
                results = results + item.ABC;
            }
            return(results);
        }
        class ConsoleApp1
        {
            public int Num;
            public char ABC;
        }
    }
    
}
