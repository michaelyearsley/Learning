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
            Console.WriteLine(RankTeams(arr = new string[]{ "FVSHJIEMNGYPTQOURLWCZKAX","AITFQORCEHPVJMXGKSLNZWUY","OTERVXFZUMHNIYSCQAWGPKJL","VMSERIJYLZNWCPQTOKFUHAXG","VNHOZWKQCEFYPSGLAMXJIUTR","ANPHQIJMXCWOSKTYGULFVERZ","RFYUXJEWCKQOMGATHZVILNSP","SCPYUMQJTVEXKRNLIOWGHAFZ","VIKTSJCEYQGLOMPZWAHFXURN","SVJICLXKHQZTFWNPYRGMEUAO","JRCTHYKIGSXPOZLUQAVNEWFM","NGMSWJITREHFZVQCUKXYAPOL","WUXJOQKGNSYLHEZAFIPMRCVT","PKYQIOLXFCRGHZNAMJVUTWES","FERSGNMJVZXWAYLIKCPUQHTO","HPLRIUQMTSGYJVAXWNOCZEKF","JUVWPTEGCOFYSKXNRMHQALIZ","MWPIAZCNSLEYRTHFKQXUOVGJ","EZXLUNFVCMORSIWKTYHJAQPG","HRQNLTKJFIEGMCSXAZPYOVUW","LOHXVYGWRIJMCPSQENUAKTZF","XKUTWPRGHOAQFLVYMJSNEIZC","WTCRQMVKPHOSLGAXZUEFYNJI" }));
        }
        public static string RankTeams(string[] votes)
        {
            if (votes.Length == 1)
                foreach (var item in votes)
                {
                    return(item);
                }
            List<Leetcode1366> winner = new List<Leetcode1366>();
            StringBuilder arr = new StringBuilder();
            Dictionary<char, int> votecount = new Dictionary<char, int>();
            string vote = string.Empty;
            for (int i = 0; i < votes.Length; i++)
            {
                arr.Append(votes[i]);
            }
            string arr2 = Convert.ToString(arr);
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
                word = word.Replace("]", " ");
                int number = int.Parse(Convert.ToString(word.Substring(4,2)));                  
                winner.Add(new Leetcode1366() { Num = number, ABC = word[1] });
            }
            
            winner.Sort(delegate (Leetcode1366 x, Leetcode1366 y)
            {
                if(x.Num == y.Num) return x.ABC.CompareTo(y.ABC); 
                else return x.Num.CompareTo(y.Num);
            });
            String results = string.Empty;
            Console.WriteLine(votes.Length);
            foreach (var item in winner)
            {
                Console.WriteLine($"{item.Num}, {item.ABC}");
                results = results + item.ABC;
            }
            return(results);
        }
        class Leetcode1366
        {
            public int Num;
            public char ABC;
        }
    } 
}
