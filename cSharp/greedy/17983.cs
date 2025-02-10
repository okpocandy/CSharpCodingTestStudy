using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _17983
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)> ls = new List<(int, int)> ();
            for(int i=0; i<n; i++)
            {
                int[] dt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int d = dt[0];
                int t = dt[1];
                ls.Add((d,t));  
            }
            ls.Sort((a,b) => b.Item2.CompareTo(a.Item2));
            int time = ls.First().Item2;
            foreach(var i in ls)
            {
                int sd = i.Item1;
                int st = i.Item2;
                if(st <= time)
                {
                    time = st;
                }
                time -= sd;
            }
            Console.WriteLine(time);
        }
    }
}
