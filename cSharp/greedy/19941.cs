using System;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _19941
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            char[] arrange = Console.ReadLine().ToCharArray();
            int ans = 0;

            for (int i = 0; i < arrange.Length; i++)
            {
                if (arrange[i] == 'P') 
                {
                   
                    int start = Math.Max(0, i - k);
                    int end = Math.Min(n - 1, i + k);

                    for (int j = start; j <= end; j++)
                    {
                        if (arrange[j] == 'H') 
                        {
                            arrange[j] = 'E'; 
                            ans++;
                            break; 
                        }
                    }
                }
            }

            Console.WriteLine(ans);
        }
    }
}
