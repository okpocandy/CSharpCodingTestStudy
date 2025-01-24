using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _1263
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int t, int s)> tasks = new List<(int t, int s)>();
            int ans = 0;
            for(int i=0; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                tasks.Add((ints[0], ints[1]));
            }
            tasks.Sort((x,y) => y.s.CompareTo(x.s));
            int now = tasks.First().s;
            foreach(var task in tasks)
            {
                int wit = task.t;
                int wis = task.s;
                if (now >= wis)
                    now = wis;
                now -= wit;
                if(now < 0)
                {
                    now = -1;
                    break;
                }
            }

            Console.WriteLine(now);
        }
    }
}
