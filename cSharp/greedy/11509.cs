using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _11509
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] balloons = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Dictionary<int, int> arrows = new Dictionary<int, int>();
            int ans = 0;

            foreach (int height in balloons)
            {
                if (arrows.ContainsKey(height) && arrows[height] > 0)
                {
                    arrows[height]--;
                }
                else
                {
                    ans++;
                }

                if (!arrows.ContainsKey(height - 1))
                    arrows[height - 1] = 0;
                arrows[height - 1]++;
            }

            Console.WriteLine(ans);
        }
    }
}
