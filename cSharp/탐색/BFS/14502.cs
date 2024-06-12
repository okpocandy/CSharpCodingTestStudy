using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _14502
    {
        static int[] dy = { 1, 0, -1, 0 };
        static int[] dx = { 0, 1, 0, -1 };
        static int n;
        static int m;
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            m = nm[1];
            List<int[]> graph = new List<int[]>();
            for(int i=0; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph.Add(ints);
            }

            Combination c = new Combination(n * m, 3);
            int res = 0;
            while (c != null)
            {
                List<int[]> re_graph = DeepCopy(graph);
                int[] comb = c.ToArray();
                
                if(re_graph[comb[0] / m][comb[0] % m] == 0 
                    && re_graph[comb[1] / m][comb[1] % m] == 0
                    && re_graph[comb[2] / m][comb[2] % m] == 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        re_graph[comb[i] / m][comb[i] % m] = 1;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (graph[i][j] == 2)
                            {
                                BFS(re_graph, i, j);
                            }
                        }
                    }
                    int cnt = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (re_graph[i][j] == 0)
                            {
                                cnt++;
                            }
                        }
                    }
                    res = Math.Max(cnt, res);
                    
                }
                c = c.Successor();
            }
            Console.WriteLine(res);
        }


        static List<int[]> DeepCopy(List<int[]> original)
        {
            List<int[]> copy = new List<int[]>();
            foreach (var array in original)
            {
                int[] newArray = new int[array.Length];
                Array.Copy(array, newArray, array.Length);
                copy.Add(newArray);
            }
            return copy;
        }

        static void BFS(List<int[]> graph, int startY, int startX)
        {
            Queue<(int,int)> q = new Queue<(int,int)>();
            q.Enqueue((startY,startX));
            while(q.Count > 0)
            {
                (int y, int x) = q.Dequeue();
                for(int i=0; i<4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];
                    if (ny < 0 || nx < 0 || ny >= n || nx >= m)
                        continue;
                    if (graph[ny][nx] == 0)
                    {
                        q.Enqueue((ny,nx));
                        graph[ny][nx] = 2;
                    }

                }
            }
        }

        class Combination
        {
            private long n = 0;
            private long k = 0;
            private long[] data = null;

            public Combination(long n, long k)
            {
                if (n < 0 || k < 0)
                {
                    throw new Exception("Negative parameter in constructor");
                }

                this.n = n;
                this.k = k;
                this.data = new long[k];

                for (long i = 0; i < k; ++i)
                {
                    this.data[i] = i;
                }
            }

            public Combination Successor()
            {
                if (this.data.Length == 0 ||
                    this.data[0] == this.n - this.k)
                {
                    return null;
                }

                Combination answer = new Combination(this.n, this.k);

                long i;
                for (i = 0; i < this.k; ++i)
                {
                    answer.data[i] = this.data[i];
                }

                for (i = this.k - 1; i > 0 && answer.data[i] == this.n - this.k + i; --i) ;

                ++answer.data[i];

                for (long j = i; j < this.k - 1; ++j)
                {
                    answer.data[j + 1] = answer.data[j] + 1;
                }

                return answer;
            }

            public string[] ApplyTo(string[] strarr)
            {
                if (strarr.Length != this.n)
                {
                    throw new Exception("Bad array size");
                }

                string[] result = new string[this.k];

                for (long i = 0; i < result.Length; ++i)
                {
                    result[i] = strarr[this.data[i]];
                }

                return result;
            }

            public static long Choose(long n, long k)
            {
                if (n < 0 || k < 0)
                {
                    throw new Exception("Invalid negative parameter in Choose()");
                }

                if (n < k)
                {
                    return 0;
                }

                if (n == k)
                {
                    return 1;
                }

                long delta, iMax;

                if (k < n - k)
                {
                    delta = n - k;
                    iMax = k;
                }
                else
                {
                    delta = k;
                    iMax = n - k;
                }

                long answer = delta + 1;

                for (long i = 2; i <= iMax; ++i)
                {
                    checked { answer = (answer * (delta + i)) / i; }
                }

                return answer;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("{ ");

                for (long i = 0; i < this.k; ++i)
                {
                    sb.AppendFormat("{0} ", this.data[i]);
                }

                sb.Append("}");

                return sb.ToString();
            }

            public int[] ToArray()
            {
                int[] ints = new int[this.k];
                for (long i = 0; i < this.k; ++i)
                {
                    ints[i] = (int)this.data[i];
                }
                return ints;
            }
        }
    }
}
