using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.큐
{
    internal class _11866
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            var ans = new Queue<int>(Enumerable.Range(1, n));
            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            int cnt = 0;
            while (ans.Count > 1)
            {
                cnt++;
                if (cnt == k)
                {
                    sb.Append($"{ans.Dequeue()}, ");
                    cnt = 0;
                }
                else
                    ans.Enqueue(ans.Dequeue());
            }
            sb.Append($"{ans.Dequeue()}>");
            Console.WriteLine(sb.ToString());
        }
    }
}
