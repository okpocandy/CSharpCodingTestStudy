using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최소스패닝트리
{
    internal class _21924
    {
        class Edge : IComparable<Edge>
        {
            public int Src, Dest, Weight;

            public Edge(int src, int dest, int weight)
            {
                Src = src;
                Dest = dest;
                Weight = weight;
            }

            public int CompareTo(Edge other)
            {
                return this.Weight.CompareTo(other.Weight);
            }
        }

        class DisjoinSet
        {
            private int[] parent, rank;

            public DisjoinSet(int n)
            {
                parent = new int[n];
                rank = new int[n];
                for (int i = 0; i < n; i++) parent[i] = i;
            }

            public int Find(int i)
            {
                if (parent[i] != i)
                    parent[i] = Find(parent[i]);
                return parent[i];
            }

            public void Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);

                if (rootX != rootY)
                {
                    if (rank[rootX] < rank[rootY])
                        parent[rootX] = rootY;
                    else if (rank[rootX] > rank[rootY])
                        parent[rootY] = rootX;
                    else
                    {
                        parent[rootY] = rootX;
                        rank[rootX]++;
                    }
                }
            }

            class KruskalMST
            {
                public List<Edge> Kruskal(List<Edge> edges, int V)
                {
                    List<Edge> result = new List<Edge>();
                    edges.Sort();

                    DisjoinSet ds = new DisjoinSet(V);

                    foreach (var edge in edges)
                    {
                        int x = ds.Find(edge.Src);
                        int y = ds.Find(edge.Dest);

                        if (x != y)
                        {
                            result.Add(edge);
                            ds.Union(x, y);
                        }

                        if (result.Count == V - 1)
                            break;
                    }
                    return result;
                }

            }

            static void Main(string[] args)
            {
                int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int v = ve[0];
                int e = ve[1];
                List<Edge> edges = new List<Edge>();
                long ans = 0;
                for (int i = 0; i < e; i++)
                {
                    int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    edges.Add(new Edge(ints[0]-1, ints[1]-1, ints[2]));
                    ans += ints[2];
                }
                KruskalMST mst = new KruskalMST();
                List<Edge> result = mst.Kruskal(edges, v);
                long cnt = 0;
                foreach (var edge in result)
                {
                    cnt += edge.Weight;
                }
                
                if (result.Count != v-1)
                    Console.WriteLine(-1);
                else
                    Console.WriteLine(ans - cnt);

            }
        }
    }
}
