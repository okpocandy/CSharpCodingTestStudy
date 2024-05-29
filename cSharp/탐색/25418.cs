using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    
    internal class _25418
    {
        static int[] visited = new int[1000001];
        static Queue<int> q = new Queue<int>();
        static void Main(string[] args)
        {
            int[] ak = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ak[0];
            int k = ak[1];

            Console.WriteLine(BFS(a,k));
        }

        static int BFS(int a, int k)
        {
            q.Enqueue(a);

            while(q.Count > 0)
            {
                int v = q.Dequeue();
                if(v == k)
                    return visited[v];
                if(v+1 <= 1000000 && visited[v+1] == 0)
                {
                    q.Enqueue(v + 1);
                    visited[v+1] = visited[v] + 1;
                }
                if (v * 2 <= 1000000 && visited[v*2] == 0)
                {
                    q.Enqueue(v*2);
                    visited[v*2] = visited[v] + 1;
                }
            }
            return 0;
        }
    }
}
