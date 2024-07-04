using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _30804
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int ans = 0;
            int left = 0;
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            for (int right = 0; right < n; right++)
            {
                if (!countMap.ContainsKey(ar[right]))
                {
                    countMap[ar[right]] = 0;
                }
                countMap[ar[right]]++;

                while (countMap.Count > 2)
                {
                    countMap[ar[left]]--;
                    if (countMap[ar[left]] == 0)
                    {
                        countMap.Remove(ar[left]);
                    }
                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            Console.WriteLine(ans);
        }
    }
}
