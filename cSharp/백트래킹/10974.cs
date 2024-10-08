using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.백트래킹
{
    internal class _10974
    {
        static bool[] visited;
        static int[] result;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            visited = new bool[n];
            result = new int[n];
            Permute(n, 0);
        }

        static void Permute(int N, int depth)
        {
            if(depth == N)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for(int i=1; i<=N; i++)
            {
                if ((!visited[i-1]))
                {
                    visited[i-1] = true;
                    result[depth] = i;
                    Permute(N, depth + 1);
                    visited[i-1] = false;
                }
            }
        }
    }
}
