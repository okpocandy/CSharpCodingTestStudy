using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _21758
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] honeys = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] ssum = new int[100001];
            ssum[0] = honeys[0];
            int ans = 0;
            for(int i=1; i<honeys.Length; i++)
            {
                ssum[i] = ssum[i-1] + honeys[i];
            }
            for (int i = 1; i < n - 1; i++)
                ans = Math.Max(ans, ssum[n - 2] + ssum[i - 1] - honeys[i]);
            for (int i = 1; i < n - 1; i++)
                ans = Math.Max(ans, ssum[n - 1] - honeys[0] + ssum[n-1] - ssum[i] - honeys[i]);
            for (int i = 1; i < n - 1; i++)
                ans = Math.Max(ans, ssum[n - 2] - honeys[0] + honeys[i]);
            Console.WriteLine(ans);
        }
    }
}
