using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1911
    {
        static void Main(string[] args)
        {
            int[] nl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nl[0];
            int l = nl[1];
            List<(int s, int e)> ls = new List<(int s, int e)>();
            for(int i=0; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ls.Add((ints[0], ints[1]));
            }
            ls.Sort((a,b) => a.s.CompareTo(b.s));
            int ans = 0;
            int pre = ls[0].s;
            foreach(var tmp in ls)
            {
                int ms = tmp.s;
                if (ms > pre)
                    pre = ms;
                while(pre < tmp.e)
                {
                    pre += l;
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
