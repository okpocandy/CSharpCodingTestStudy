using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2170
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int x, int y)> ls = new List<(int x, int y)>();
            for (int i = 0; i < n; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ls.Add((xy[0], xy[1]));
            }
            ls.Sort((a,b) => a.x.CompareTo(b.x));

            int ans = 0;
            int pre = ls[0].x;
            foreach(var l  in ls)
            {
                int sx = l.x;
                int sy = l.y;
                if(pre>= sy)
                    continue;
                if (pre <= sx)
                    pre = sx;
                ans += sy - pre;
                pre = sy;
            }
            Console.WriteLine(ans);
        }
    }
}
