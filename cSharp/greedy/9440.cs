using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _9440
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int n = nums[0];
                if (n == 0)
                    break;
                int[] graph = nums[1..];
                Array.Sort(graph);
                int cnt = 0;
                for(int i=0; i<graph.Length; i++)
                {
                    if (graph[i] == 0)
                        cnt++;

                }
                List<int> ls = new List<int>();
                for(int i=0; i<2; i++)
                {
                    ls.Add(graph[i+cnt]);
                }
                for(int i=0; i<cnt; i++)
                {
                    ls.Add(0);
                }
                for(int i=cnt+2; i<graph.Length; i++) { ls.Add(graph[i]); }
                string s1 = "";
                string s2 = "";
                for(int i=0; i<ls.Count; i++)
                {
                    if(i%2 == 0)
                        s1 += ls[i];
                    else
                        s2 += ls[i];
                }
                Console.WriteLine(int.Parse(s1) + int.Parse(s2));
                

            }
        }
    }
}
