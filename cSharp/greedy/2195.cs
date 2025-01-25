using System;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _2195
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string p = Console.ReadLine();

            int index = 0;
            int ans = 0;

            while (index < p.Length)
            {
                int maxMatch = 0;

                for (int start = 0; start < s.Length; start++)
                {
                    int matchLength = 0;

                    while (index + matchLength < p.Length &&
                           start + matchLength < s.Length &&
                           s[start + matchLength] == p[index + matchLength])
                    {
                        matchLength++;
                    }

                    maxMatch = Math.Max(maxMatch, matchLength);
                }

                index += maxMatch;
                ans++;
            }

            Console.WriteLine(ans);
        }
    }
}
