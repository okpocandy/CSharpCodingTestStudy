using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.큐
{
    internal class _1966
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int n = nm[0];
                int m = nm[1];  // 몇 번째로 인쇄되었는지 궁금한 문서가 현재 q에 몇 번째에 있는지
                int[] inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Queue<(int, int)> q = new Queue<(int, int)>();
                int cnt = 0;
                int f = 987654321;
                for (int j = 0; j < inp.Length; j++)
                {
                    q.Enqueue((j, inp[j]));
                }
                while (q.Count > 1)
                {
                    (int now, int value) = q.Dequeue();
                    int max_value = q.Max(a => a.Item2);
                    if (value < max_value)
                    {
                        q.Enqueue((now, value));
                    }
                    else
                    {
                        cnt++;
                        if (now == m)
                        {
                            f = 1;
                            break;
                        }

                    }
                }
                if (f == 1)
                    Console.WriteLine(cnt);
                else
                {
                    q.Dequeue();
                    cnt++;
                    Console.WriteLine(cnt);
                }

            }
        }
    }
}
