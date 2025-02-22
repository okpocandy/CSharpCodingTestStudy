using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _23843
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] con = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            foreach(var i in con)
            {
                pq.Enqueue(i, -i);
            }
            int ans = 0;
            while(pq.Count>= m)
            {
                
                List<int> ints = new List<int>();
                for(int i=0; i<m-1; i++)
                {
                    ints.Add(pq.Dequeue());
                }
                int c1 = pq.Dequeue();
                foreach (var i in ints)
                {
                    if(i-c1 >0)
                        pq.Enqueue(i - c1, -(i - c1));
                }
                ans += c1;
            }
            int tmp = 0;
            while(pq.Count>0)
                tmp = pq.Dequeue();
            Console.WriteLine(ans + tmp);


        }
    }
}
