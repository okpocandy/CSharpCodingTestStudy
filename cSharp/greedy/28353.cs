using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _28353
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int[] cats = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(cats);
            int l = 0;
            int r = n - 1;
            int ans = 0;
            while(l < r)
            {
                if (cats[l] + cats[r] <= k)
                {
                    ans++;
                    l++;
                    r--;
                }
                else
                {
                    r--;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
