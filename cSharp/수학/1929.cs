using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1929
    {
        static void Main(string[] args)
        {
            int[] mn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = mn[0];
            int n = mn[1];
            StringBuilder sb = new StringBuilder();
            List<int> ints = new List<int>();
            for(int i=m; i<=n; i++) ints.Add(i);
            for(int i=2; i<n+1; i++)
            {
                List<int> del = ints.FindAll(x => x%i==0);
                del.Remove(i);
                if(del.Count > 0)
                {
                    foreach (var x in del)
                        ints.Remove(x);
                }

            }
            foreach (var i in ints)
                sb.Append(i + "\n");
            Console.WriteLine(sb);
        }
    }
}



/*
 using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1929
    {
        static void Main(string[] args)
        {
            int[] mn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = mn[0];
            int n = mn[1];

            // 에라토스테네스의 체 알고리즘 사용
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++) isPrime[i] = true;

            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            // 소수 출력
            StringBuilder sb = new StringBuilder();
            for (int i = m; i <= n; i++)
            {
                if (isPrime[i])
                {
                    sb.Append(i).Append('\n');
                }
            }
            Console.WriteLine(sb);
        }
    }
}
 */