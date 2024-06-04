using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 팀_결성
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] parent = new int[nm[0] + 1];
            for(int i=1; i < nm[0]+1;  i++) { parent[i] = i; }
            for(int i=0; i < nm[1]; i++)
            {
                int[] mab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int m = mab[0];
                int a = mab[1];
                int b = mab[2];
                if(m == 0)
                    UnionParent(parent, a,b);
                else
                {
                    if (FindParent(parent, a) == FindParent(parent, b))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
            }

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

7 8
0 1 3
1 1 7
0 7 6
1 7 1
0 3 7
0 4 2
0 1 1
1 1 1

*/
