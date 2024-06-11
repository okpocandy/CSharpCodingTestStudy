using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 뱀
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] map = new int[n + 2, n + 2];
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };
            for (int i = 0; i < map.GetLength(0); i++)
            {
                map[0, i] = 1;
                map[i, 0] = 1;
                map[n+1, i] = 1;
                map[i, n+1] = 1;
            }
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int[] yx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                map[yx[0], yx[1]] = 2;

            }
            int l = int.Parse(Console.ReadLine());
            Queue<(int,char)> q = new Queue<(int,char)>();
            for (int i = 0; i < l; i++)
            {
                string[] a = Console.ReadLine().Split();
                q.Enqueue((int.Parse(a[0]), char.Parse(a[1])));
            }
            List<int[]> snake = new List<int[]>();
            snake.Add(new int[] { 1, 1 });
            int time = 0;
            int y = 1;
            int x = 1;
            int dir = 0;
            (int t, char d) = q.Dequeue();
            while (true)
            {
                if(time == t) {
                    if (d == 'L')
                        dir -= 1;
                    else if (d == 'D')
                        dir += 1;
                    if (dir == 4)
                        dir = 0;
                    if (dir == -1)
                        dir = 3;
                    if(q.Count !=0)
                    {
                        (t, d) = q.Dequeue();
                    }
                }
                int ny = y + dy[dir];
                int nx = x + dx[dir];
                if (map[ny, nx] == 1) { break; }
                if (snake.Any(s => s[0] == ny && s[1] == nx))
                {
                    break;
                }
                snake.Add(new int[] { ny, nx });
                if (map[ny,nx] != 2) { snake.RemoveAt(0); }
                if (map[ny, nx] == 2) { map[ny,nx] = 0; }
                y = ny;
                x = nx;
                time++;
            }
            Console.WriteLine(time + 1);
        }
    }
}

/*



*/