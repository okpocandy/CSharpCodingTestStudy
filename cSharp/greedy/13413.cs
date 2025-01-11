using System;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 오셀로_재배치
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 0; test < t; test++)
            {
                int n = int.Parse(Console.ReadLine()); 
                string initial = Console.ReadLine(); 
                string target = Console.ReadLine(); 

                int w_to_b = 0;
                int b_to_w = 0;

                for (int i = 0; i < n; i++)
                {
                    if (initial[i] == 'W' && target[i] == 'B')
                        w_to_b++;
                    else if (initial[i] == 'B' && target[i] == 'W')
                        b_to_w++;
                }
                int swaps = Math.Min(w_to_b, b_to_w); 
                int flips = Math.Abs(w_to_b - b_to_w);
                Console.WriteLine(swaps + flips); 
            }
        }
    }
}
