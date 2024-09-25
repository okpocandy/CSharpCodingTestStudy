using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.트리
{
    internal class _17073
    {
        static void Main(string[] args)
        {
            int[] nw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nw[0];
            int w = nw[1];
            List<int>[] graph = new List<int>[n+1];
            int cnt = 0;
            for(int i=0; i<n+1; i++)
            {
                graph[i] = new List<int>();
            }
            for(int i=0; i<n-1; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ints[0]].Add(ints[1]);
                graph[ints[1]].Add(ints[0]);
            }
            for(int i=2; i<=n; i++)
            {
                if (graph[i].Count == 1)
                    cnt++;
            }
            double ans = (double)w / (double)cnt;
            Console.WriteLine(ans);
        }
    }
}
