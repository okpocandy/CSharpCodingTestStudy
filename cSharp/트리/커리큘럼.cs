using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 커리큘럼
    {
        static int v;
        static int e;
        static int[] indegree;
        static int[] time;
        static List<int>[] graph;

        static void Main(string[] args)
        {
            v = int.Parse(Console.ReadLine());
            indegree = new int[v + 1];
            graph = new List<int>[v + 1];
            time = new int[v + 1];

            for (int i = 0; i < v + 1; i++)
            {
                graph[i] = new List<int>();
            }

            for(int i=1; i < v + 1; i++)
            {
                int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                time[i] = data[0];
                for(int j=1; j< data.Length-1; j++)
                {
                    indegree[i]++;
                    graph[data[j]].Add(i);
                }
            }

            TopologySort();

        }

        static void TopologySort()
        {
            int[] result = new int[v + 1];
            Array.Copy(time, result, time.Length);

            Queue<int> q = new Queue<int>();

            for (int i = 1; i < v + 1; i++)
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }

            while (q.Count > 0)
            {
                int now = q.Dequeue();
                foreach (var i in graph[now])
                {
                    result[i] = Math.Max(result[i], result[now] + time[i]);
                    indegree[i] -= 1;
                    if (indegree[i] == 0)
                        q.Enqueue(i);
                }
            }

            for(int i=1; i<v+1; i++)
                Console.WriteLine(result[i]);

        }
    }
}

/*

5
10 -1
10 1 -1
4 1 -1
4 3 1 -1
3 3 -1

*/