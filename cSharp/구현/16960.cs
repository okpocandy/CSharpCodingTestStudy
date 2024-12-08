using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class _16960
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int[]> graph = new List<int[]>();
            int ans = 0;
            for(int i=0; i < nm[0]; i++)
            {
                graph.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            }
            for(int k=0; k < nm[0];  k++)
            {
                HashSet<int> itns = new HashSet<int>();
                for (int i = 0; i < nm[0]; i++)
                {
                    if (i == k)
                        continue;
                    for (int j = 1; j < graph[i].Length; j++)
                    {
                        itns.Add(graph[i][j]);
                    }
                }
                if(itns.Count == nm[1])
                {
                    ans = 1;
                }
            }
            Console.WriteLine(ans);
            
        }
    }
}
