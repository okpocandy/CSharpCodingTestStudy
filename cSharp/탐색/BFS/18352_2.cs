using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _18352_2
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("-1");
                return;
            }

            int[] nmkx = Array.ConvertAll(input.Split(), int.Parse);
            int n = nmkx[0];
            int m = nmkx[1];
            int k = nmkx[2];
            int x = nmkx[3];

            List<int>[] graph = new List<int>[n + 1];
            for (int i = 0; i <= n; i++)
            {
                graph[i] = new List<int>();
            }

            int[] visited = new int[n + 1];

            for (int i = 0; i < m; i++)
            {
                string edgeInput = Console.ReadLine();
                if (string.IsNullOrEmpty(edgeInput))
                {
                    continue; 
                }

                int[] edge = Array.ConvertAll(edgeInput.Split(), int.Parse);
                graph[edge[0]].Add(edge[1]);
            }

            BFS(graph, x, visited);

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (visited[i] == k + 1)
                    sb.AppendLine($"{i}");
            }

            if (sb.Length == 0)
                Console.WriteLine("-1");
            else
                Console.Write(sb.ToString());
        }

        static void BFS(List<int>[] graph, int start, int[] visited)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = 1;

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                foreach (var next in graph[node])
                {
                    if (visited[next] == 0)
                    {
                        visited[next] = visited[node] + 1;
                        queue.Enqueue(next);
                    }
                }
            }
        }
    }
}
