using System;

namespace _2dArray
{
    class Program
    {

        static void Main(string[] args)
        {
            Print2d();
            Print3d();
        }
        public static void Print2d()
        {
            string[] names = new string[4] { "daniel", "John", "Jane", "Tobi" };
            
            var namelist = new string[4, 2]
            {
                {"daniel" ,"28y"},
                {"John", "34y" },
                {"Jane", "23y" },
                {"Tobi", "25y" }
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)

                {

                    Console.Write("{0} ", namelist[i, j]);

                }
                Console.WriteLine();
            }
            
        }
        public static void Print3d()
        {
            var namelist2 = new string[2, 2, 3]
            {
                    {
                        {"daniel" ,"28y", "eye color is blue"},
                        {"John", "34y", "eye color is green"}
                    },
                    {
                        {"Jane", "23y", "eye color is black"},
                        {"Tobi", "25y", "eye color is Brown"}
                    },
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {

                        Console.Write("{0} ", namelist2[i, j, k]);
                    }
                    Console.WriteLine();
                }
            }
            
        }    
           
    }
}
