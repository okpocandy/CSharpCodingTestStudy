using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 도시_분할_계획
    {
        static void Main(string[] args)
        {
            int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = ve[0];
            int e = ve[1];

            int[] parent = new int[v + 1];
            List<int[]> edges = new List<int[]>();
            int result = 0;

            for (int i = 1; i < v + 1; i++) { parent[i] = i; }
            for (int i = 0; i < e; i++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                edges.Add([abc[2], abc[1], abc[0]]);
            }
            edges.Sort((a, b) =>
            {
                if (a[0] > b[0])
                    return 1;
                else
                    return -1;
            });
            int last = 0;
            foreach (var edge in edges)
            {
                (int cost, int a, int b) = (edge[0], edge[1], edge[2]);
                if (FindParent(parent, a) != FindParent(parent, b))
                {
                    UnionParent(parent, a, b);
                    result += cost;
                    last = cost;
                }
            }
            Console.WriteLine(result - last);

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

7 12
1 2 3
1 3 2
3 2 1
2 5 2
3 4 4
7 3 6
5 1 5
1 6 2
6 4 1
6 5 3
4 5 3
6 7 4



*/