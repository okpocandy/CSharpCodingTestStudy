using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _2644
    {
        static int ans = -1;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ab[0];
            int b = ab[1];
            int m = int.Parse(Console.ReadLine());

            List<int>[] array = new List<int>[n+1];
            int[] visited = new int[n+1];
            for (int i = 0; i <= n; i++)
                array[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                int[] pc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                array[pc[0]].Add(pc[1]);
                array[pc[1]].Add(pc[0]);
            }
            DFS(array, a, visited, 0, b);
            Console.WriteLine(ans);
        }
        static void DFS(List<int>[] array, int node, int[] visited, int count, int target)
        {
            if (node == target) {
                ans = count;
                return; }
            visited[node] = 1;
            foreach(var i in array[node])
            {
                if (visited[i] == 0)
                    DFS(array, i, visited, count+1, target);
            }
        }
    }
}
