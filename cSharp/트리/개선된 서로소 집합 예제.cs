using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 개선된_서로소_집합_예제
    {
        static void Main(string[] args)
        {
            int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = ve[0];
            int e = ve[1];
            int[] parent = new int[v + 1];
            for (int i = 1; i < v + 1; i++)
                parent[i] = i;

            for (int i = 0; i < e; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                UnionParent(parent, ab[0], ab[1]);
            }

            Console.WriteLine("각 우너소가 속한 집합: ");
            for (int i = 1; i < v + 1; i++)
                Console.WriteLine(FindParent(parent, i));

            Console.WriteLine("부모 테이블: ");
            for (int i = 1; i < v + 1; i++)
                Console.WriteLine(parent[i]);
        }

        static int FindParent(int[] parent, int x)
        {
            if (parent[x] != x)
                parent[x] =  FindParent(parent, parent[x]);
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
 
6 4
1 4
2 3
2 4
5 6

 */