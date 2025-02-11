using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _11000
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int, int> pq = new System.Collections.Generic.PriorityQueue<int, int> ();
            List<(int, int)> ls = new List<(int, int)> ();
            for(int i=0; i<n; i++)
            {
                int[] st = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int s = st[0];
                int t = st[1];
                ls.Add((s, t));
            }
            ls.Sort((a,b) => a.Item1.CompareTo(b.Item1));
            pq.Enqueue(ls.First().Item2, ls.First().Item2);
            int ans = 1;
            for(int i=1; i<n; i++)
            {
                int tmp = pq.Dequeue();
                if (ls[i].Item1 < tmp)
                {
                    ans++;
                    pq.Enqueue(tmp, tmp);
                    
                }
                pq.Enqueue(ls[i].Item2, ls[i].Item2);
            }
            Console.WriteLine(ans);
            


        }
    }
}
