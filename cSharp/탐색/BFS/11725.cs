using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _11725
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] parent = new int[n + 1];
            StringBuilder sb = new StringBuilder();
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            for (int i = 0; i < n - 1; i++)
            {
                int[] uv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int u = uv[0];
                int v = uv[1];
                graph[u].Add(v);
                graph[v].Add(u);


            }
            BFS(graph, 1, parent);
            for (int i = 2; i <= n; i++)
            {
                sb.Append(parent[i] + "\n");
            }
            Console.WriteLine(sb.ToString());


        }
        static void BFS(List<int>[] graph, int start, int[] parent)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                foreach (int i in graph[node])
                {
                    if (parent[i] == 0)
                    {
                        queue.Enqueue(i);
                        parent[i] = node;
                    }
                }
            }
        }

    }


}
