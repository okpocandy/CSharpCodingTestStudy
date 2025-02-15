using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _23524
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            PriorityQueue<(int a, int b), int> pq = new PriorityQueue<(int a, int b), int>();
            for (int i = 0; i < m; i++)
            {
                pq.Enqueue((aa[i], bb[i]), -bb[i]);
            }
            int time = 24 * n;
            int ans = 0;
            while (time > 0 && pq.Count > 0)
            {
                (int ta, int tb) = pq.Dequeue();
                int mul = 0;
                if (tb != 1)
                    mul = (101 - ta) / tb;
                else
                    mul = (100 - ta) / tb;
                if (mul <= time)
                {
                    ans += ((ta + tb * mul) > 100 ? 100 : (ta + tb * mul));
                    time -= mul;
                    //Console.WriteLine(ta + tb * mul);
                }
                else
                {
                    ans += ta + tb * time;
                    time -= time;
                    //Console.WriteLine(ta + tb * time);
                }
            }
            while (pq.Count > 0)
            {
                ans += pq.Dequeue().a;
            }
            Console.WriteLine(ans);

        }
    }
}