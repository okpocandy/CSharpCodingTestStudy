using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _19368
    {
        static void Main(string[] args)
        {
            int[] nht = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nht[0];
            int h = nht[1];
            int t = nht[2];
            int maxt = t;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for(int i=0; i<n; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                pq.Enqueue(tmp, -tmp);
            }
            while(t > 0)
            {
                var height = pq.Dequeue();
                if (height < h)
                {
                    pq.Enqueue(height, -height); // 다시 큐에 삽입
                    break;
                }
                if (height == 1)
                {
                    pq.Enqueue(height, -height);
                    break;
                }
                    
                height /= 2;
                pq.Enqueue(height, -height);
                t--;
            }
            int gi = pq.Dequeue();
            if(gi >= h)
            {
                Console.WriteLine("NO");
                Console.WriteLine(gi);
            }
            else
            {
                Console.WriteLine("YES");
                Console.WriteLine(maxt - t);
                
            }
        }
    }
}
