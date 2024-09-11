using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.큐
{
    internal class _18258
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            List<int> ans = new List<int>();
            for(int i=1; i<=n; i++)
            {
                q.Enqueue(i);
            }
            while(true)
            {
                ans.Add(q.Dequeue());
                if (q.Count == 0)
                    break;
                int tmp = q.Dequeue();
                q.Enqueue(tmp);
            }
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
