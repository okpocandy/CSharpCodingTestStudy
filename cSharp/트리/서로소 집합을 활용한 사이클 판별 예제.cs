using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 서로소_집합을_활용한_사이클_판별_예제
    {
        static void Main(string[] args)
        {
            int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = ve[0];
            int e = ve[1];
            int[] parent = new int[v + 1];
            for (int i = 1; i < v + 1; i++) { parent[i] = i; }
            bool cycle = false;

            for (int i = 0; i < e; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (FindParent(parent, ab[0]) == FindParent(parent, ab[1]))
                {
                    cycle = true;
                    break;
                }
                else
                    UnionParent(parent, ab[0], ab[1]);
            }
            if (cycle) { Console.WriteLine("사이클이 발새했습니다."); }
            else { Console.WriteLine("사이클이 발생하지 않았습니다."); }
           
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

3 3
1 2
1 3
2 3

*/