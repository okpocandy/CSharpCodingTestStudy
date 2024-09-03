using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1158
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            List<int> ans = new List<int>();
            Queue<int> q = new Queue<int>();
            for(int i=1; i<=n; i++)
            {
                q.Enqueue(i);
            }
            while(q.Count > 0)
            {
                for(int i=0; i<k-1; i++)
                {
                    int d = q.Dequeue();
                    q.Enqueue(d);
                }
                ans.Add(q.Dequeue());
            }
            Console.WriteLine("<" + string.Join(", ", ans.ToArray())+">");
        }
    }
}
