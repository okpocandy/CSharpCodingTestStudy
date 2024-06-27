using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2667
    {
        static int n = int.Parse(Console.ReadLine());
        static int[,] graph = new int[n, n];
        static int cnt = 0;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    graph[i, j] = (int)(line[j] - '0');
                }
            }

            int result = 0;
            List<int> ls = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (DFS(j, i) == true)
                    {
                        ls.Add(cnt);
                        result++;
                        cnt = 0;
                    }
                        
                }
            }
            ls.Sort();
            Console.WriteLine(result);
            Console.WriteLine(string.Join("\n", ls.ToArray()));

        }

        static bool DFS(int x, int y)
        {
            
            if (x <= -1 || x >= n || y <= -1 || y >= n)
                return false;
            
            if (graph[y, x] == 1)
            {
                cnt++;
                graph[y, x] = 0;
                DFS(x - 1, y);
                DFS(x, y - 1);
                DFS(x + 1, y);
                DFS(x, y + 1);
                return true;
            }
            return false;
        }
    }
}
