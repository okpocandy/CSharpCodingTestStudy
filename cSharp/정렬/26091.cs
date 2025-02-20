using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _26091
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] teams = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(teams);
            int l = 0;
            int r = n - 1;
            int ans = 0;
            while(l < r)
            {
                int tmp = teams[l] + teams[r];
                if(tmp >= m)
                {
                    l++;
                    r--;
                    ans++;
                }
                else
                {
                    l++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
