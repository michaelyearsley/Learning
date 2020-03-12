using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string[] arr;
            Console.WriteLine(RankTeams(arr = new string[] { "FVSHJIEMNGYPTQOURLWCZKAX", "AITFQORCEHPVJMXGKSLNZWUY", "OTERVXFZUMHNIYSCQAWGPKJL", "VMSERIJYLZNWCPQTOKFUHAXG", "VNHOZWKQCEFYPSGLAMXJIUTR", "ANPHQIJMXCWOSKTYGULFVERZ", "RFYUXJEWCKQOMGATHZVILNSP", "SCPYUMQJTVEXKRNLIOWGHAFZ", "VIKTSJCEYQGLOMPZWAHFXURN", "SVJICLXKHQZTFWNPYRGMEUAO", "JRCTHYKIGSXPOZLUQAVNEWFM", "NGMSWJITREHFZVQCUKXYAPOL", "WUXJOQKGNSYLHEZAFIPMRCVT", "PKYQIOLXFCRGHZNAMJVUTWES", "FERSGNMJVZXWAYLIKCPUQHTO", "HPLRIUQMTSGYJVAXWNOCZEKF", "JUVWPTEGCOFYSKXNRMHQALIZ", "MWPIAZCNSLEYRTHFKQXUOVGJ", "EZXLUNFVCMORSIWKTYHJAQPG", "HRQNLTKJFIEGMCSXAZPYOVUW", "LOHXVYGWRIJMCPSQENUAKTZF", "XKUTWPRGHOAQFLVYMJSNEIZC", "WTCRQMVKPHOSLGAXZUEFYNJI" }));
        }
        public static string RankTeams(string[] votes)
        {
            if (votes.Length == 1)
                foreach (var item in votes)
                {
                    return (item);
                }
            List<ConsoleApp2> winner = new List<ConsoleApp2>();
            //Dictionary<int, int> votecount = new Dictionary<int, int>();
            
            foreach (var item in votes)
            {
                
                for (int i = 0; i < item.Length; i++)
                {
                    winner.Add(new ConsoleApp2() { Num = i, ABC = item[i]}); 
                }
            }
            return Convert.ToString(winner);
            //    foreach (var i in votecount)
            //    {
            //        string word = Convert.ToString(i);
            //        word = word.Replace("]", " ");
            //        int number = int.Parse(Convert.ToString(word.Substring(4, 2)));
            //        winner.Add(new ConsoleApp2() { Num = number, ABC = word[1] });
            //    }

            //    winner.Sort(delegate (ConsoleApp2 x, ConsoleApp2 y)
            //    {
            //        if (x.Num == y.Num) return x.ABC.CompareTo(y.ABC);
            //        else return x.Num.CompareTo(y.Num);
            //    });
            //    String results = string.Empty;
            //    Console.WriteLine(votes.Length);
            //    foreach (var item in winner)
            //    {
            //        Console.WriteLine($"{item.Num}, {item.ABC}");
            //        results = results + item.ABC;
            //    }
            //    return (results);
        }
        public class ConsoleApp2
        {
            public int Num;
            public char ABC;
        }
    }
    
}
