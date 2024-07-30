using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _1697
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int maxLength = Math.Max(n, k) * 2 + 1;
            int[] visited = new int[maxLength];
            BFS(visited, n, k);
            Console.WriteLine(visited[k] - 1);
        }

        static void BFS(int[] visited, int start, int end)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited[start] = 1;
            while (q.Count > 0)
            {
                int n = q.Dequeue();
                if (n == end)
                {
                    break;
                }
                if (n - 1 >= 0)
                {
                    if (visited[n - 1] == 0)
                    {
                        q.Enqueue(n - 1);
                        visited[n - 1] = visited[n] + 1;
                    }
                }
                if (n + 1 < 2 * end)
                {
                    if (visited[n + 1] == 0)
                    {
                        q.Enqueue(n + 1);
                        visited[n + 1] = visited[n] + 1;
                    }
                }
                if (2 * n < 2 * end)
                {
                    if (visited[2 * n] == 0)
                    {
                        q.Enqueue(2 * n);
                        visited[2 * n] = visited[n] + 1;
                    }
                }
            }
        }
    }
}
