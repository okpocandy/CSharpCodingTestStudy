using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _16953
    {
        static void Main(string[] args)
        {
            long[] ab = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = ab[0];
            long b = ab[1];

            int ans = BFS(a, b);
            if (ans == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine(ans+1);

        }

        static int BFS(long a, long b)
        {
            Queue<(long, int)> q = new Queue<(long, int)>();
            q.Enqueue((a, 0));
            
            while (q.Count > 0)
            {
                (long n, int cnt)= q.Dequeue();
                if(n == b)
                {
                    return cnt;
                }
                long nm = n * 2;
                long no = n * 10 + 1;
                if(nm <= b)
                    q.Enqueue((nm, cnt+1));
                if(no <= b)
                    q.Enqueue((no, cnt+1));

            }
            return 0;
        }
       
    }
}
