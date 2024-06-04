using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 크루스칼_알고리즘_예제
    {
        static void Main(string[] args)
        {
            int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = ve[0];
            int e = ve[1];

            int[] parent = new int[v + 1];
            List<int[]> edges = new List<int[]>();
            int result = 0;

            for(int i=1; i<v+1; i++) { parent[i] = i; }
            for(int i=0; i<e; i++ )
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                edges.Add([abc[2], abc[1], abc[0]]);
            }
            edges.Sort((a,b) => 
            {
                if (a[0] > b[0])
                    return 1;
                else 
                    return -1;
            });

            foreach (var edge in edges)
            {
                (int cost, int a, int b) = (edge[0], edge[1], edge[2]);
                if (FindParent(parent, a) != FindParent(parent, b))
                {
                    UnionParent(parent, a, b);
                    result += cost;
                }
            }
            Console.WriteLine(result);

        }

        static int FindParent(int[] parent, int x)
        {
            if (parent[x] != x)
                parent[x] = FindParent(parent, parent[x]);
            return parent[x];
        }

        static void UnionParent(int[] parent, int a, int b)
        {
            a = FindParent(parent, a);
            b = FindParent(parent, b);
            if (a < b)
                parent[b] = a;
            else
                parent[a] = b;
        }
    }
}


/*

7 9
1 2 29
1 5 75
2 3 35
2 6 34
3 4 7
4 6 23
4 7 13
5 6 53
6 7 25

*/