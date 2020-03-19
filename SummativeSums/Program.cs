using System;

namespace SummativeSums
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SumOf();
        }

        public static void SumOf()
        {
            int[] Array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] Array2 = { 999, -60, -77, 14, 160, 301 };
            int[] Array3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < Array1.Length; i++)
            {
                sum1 += Array1[i];
                //Console.WriteLine($"i={i}, #1 Array Sum: {sum1}");
            }
            Console.WriteLine($"#1 Array Sum: {sum1}");

            for (int i = 0; i < Array2.Length; i++)
            {
                sum2 += Array2[i];
                //Console.WriteLine($"i={i}, #2 Array Sum: {sum2}");
            }
            Console.WriteLine($"#2 Array Sum: {sum2}");

            for (int i = 0; i < Array3.Length; i++)
            {
                sum3 += Array3[i];
                //Console.WriteLine($"i={i}, #3 Array Sum: {sum3}");
            }
            Console.WriteLine($"#1 Array Sum: {sum3}");

            //#1 Array Sum: 42
            //#2 Array Sum: 1337
            //#3 Array Sum: 2001 



            
        }
    }
}
