using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _15686
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n  = nm[0];
            int m = nm[1];

            List<int[]> house = new List<int[]>();
            List<int[]> chicken = new List<int[]>();
            
            for(int i=1; i<n+1; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0; j<ints.Length; j++)
                {
                    if (ints[j] == 1)
                        house.Add(new int[] { i, j + 1 });
                    else if (ints[j] == 2)
                        chicken.Add(new int[] { i, j + 1 });
                }
            }

            Combination c = new Combination(chicken.Count, m);
            int min_chi = 987654321;    // 도시의 최소 치킨거리
            while (c != null)
            {
               
                int[] comb = c.ToArray();
                
                int sum = 0;            // 도시의 치킨거리
                foreach (var h in house)
                {
                    int min_dis = 987654321;    // 각 집에서 최소 치킨거리
                    foreach(var i in comb)
                    {
                        int dis = Math.Abs(chicken[i][0] - h[0]) + Math.Abs(chicken[i][1] -h[1]);
                        min_dis = Math.Min(min_dis, dis);
                    }
                    sum += min_dis;
                }
                min_chi = Math.Min(sum, min_chi);
                c = c.Successor();
            }
            Console.WriteLine(min_chi);

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
            for(long i = 0; i < this.k; ++i)
            {
                ints[i] = (int)this.data[i];
            }
            return ints;
        }
    }


}
