using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 위상_정렬_예제
    {
        static int v;
        static int e;
        static int[] indegree;
        static List<int>[] graph;
        static void Main(string[] args)
        {
            int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            v = ve[0];
            e = ve[1];
            indegree = new int[v + 1];
            graph = new List<int>[v + 1];
            
            for(int i=0; i<v+1; i++)
            {
                graph[i] = new List<int>();
            }
            
            for(int i=0; i<e; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ab[0]].Add(ab[1]);
                indegree[ab[1]] += 1;
            }

            TopologySort();

        }

        static void TopologySort()
        {
            List<int> result = new List<int>();
            Queue<int> q= new Queue<int>();

            for(int i=1; i<v+1; i++ )
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }

            while (q.Count > 0)
            {
                int now = q.Dequeue();
                result.Add(now);
                foreach(var i in graph[now])
                {
                    indegree[i] -= 1;
                    if (indegree[i] == 0)
                        q.Enqueue(i);
                }
            }

            foreach (var i in result)
                Console.WriteLine(i);

        }
    }
}

/*

7 8
1 2
1 5
2 3
2 6
3 4
4 7
5 6
6 4

*/