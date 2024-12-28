using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2304
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int l, int h)> ls = new List<(int l, int h)>();
            int ans = 0;
            for(int i=0; i<n; i++)
            {
                int[] lh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int l = lh[0];
                int h = lh[1];
                ls.Add((l, h));
            }
            int maxH = ls.Max(x => x.h);
            ls.Sort();
            List<int> maxHs = new List<int>();
            for(int i=0; i<n; i++)
            {
                if (ls[i].h == maxH)
                {
                    maxHs.Add(i);
                }
            }
            
            maxHs.Sort();
            int stmh = maxHs.First();
            int emh = maxHs.Last();
            ans += (ls[emh].l - ls[stmh].l + 1) * maxH;

            int preL = ls.First().l;
            int preH = ls.First().h;
            for(int i=0; i<=stmh; i++)
            {
                int nowL = ls[i].l;
                int nowH = ls[i].h;
                if (ls[i].h > preH)
                {
                    ans += (nowL - preL) * preH;
                    preL = nowL;
                    preH = nowH;
                }
            }
            preL = ls.Last().l;
            preH = ls.Last().h;
            for(int i=n-1; i>=emh; i--)
            {
                int nowL = ls[i].l;
                int nowH = ls[i].h;
                if (ls[i].h > preH)
                {
                    ans += (preL - nowL) * preH;
                    preL = nowL;
                    preH = nowH;
                }
            }
            Console.WriteLine(ans);
            
            
            
        }
    }
}
