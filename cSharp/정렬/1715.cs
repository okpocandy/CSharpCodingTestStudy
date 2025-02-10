using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1715
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for(int i=0; i<n; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                pq.Enqueue(tmp, tmp);
            }
            long ans = 0;
            while(pq.Count >= 2)
            {
                int a = pq.Dequeue();
                int b= pq.Dequeue();
                ans += a + b;
                pq.Enqueue(a + b, a + b);
            }
            Console.WriteLine(ans);
        }
    }
}
