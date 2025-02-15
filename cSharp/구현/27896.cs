using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _27896
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int limit = 0;
            int ans = 0;
            for(int i=0; i<n; i++)
            {
                limit += arr[i];
                pq.Enqueue(2 * arr[i], -2 * arr[i]);
                if(limit >= m)
                {
                    limit -= pq.Dequeue();
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
