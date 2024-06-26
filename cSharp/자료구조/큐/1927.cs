using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.큐
{
    internal class _1927
    {
        static void Main(string[] args)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (pq.Count == 0)
                        sb.Append(0 + "\n");
                    else
                    {
                        sb.Append(pq.Dequeue() + "\n");
                    }
                }
                else
                    pq.Enqueue(a, a);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
