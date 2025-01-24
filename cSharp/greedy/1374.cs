using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _1374
    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            List<(int s, int e)> ls = new List<(int s, int e)>();
//            for(int i=0; i<n; i++)
//            {
//                int[] nse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//                int num = nse[0];
//                int start = nse[1];
//                int end = nse[2];
//                ls.Add((start, end));
//            }
//            ls.Sort((x,y) => x.s.CompareTo(y.s));
//            int ans = 0;
//            int index = 0;
//            int st = 0;
//            int en = 0;
//            while(ls.Count>0)
//            {
//                if (index >= ls.Count)
//                {
//                    index = 0;
//                    ans++;
//                    st = 0;
//                    en = 0;
//                }
//                int tmps = ls[index].s;
//                int tmpe = ls[index].e;
//                if(tmps >= en)
//                {
//                    st = tmps;
//                    en = tmpe;
//                    ls.RemoveAt(index);
//                    continue;
//                }
//                index++;
                
//            }
//            Console.WriteLine(ans+1);
//        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<(int s, int e), int> pq = new PriorityQueue<(int s, int e), int>();
            for(int i=0; i<n; i++)
            {
                int[] nse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int num = nse[0];
                int start = nse[1];
                int end = nse[2];
                pq.Enqueue((start, end), start);
            }
            int ans = 1;

            PriorityQueue<int , int> epq = new PriorityQueue<int, int>();
            epq.Enqueue(0, 0);
            while (pq.Count > 0)
            {
                int de = epq.Dequeue();
                (int ns, int ne) = pq.Dequeue();
                if(ns >= de)
                {
                    epq.Enqueue(ne, ne);
                }
                else
                {
                    epq.Enqueue(de, de);
                    epq.Enqueue(ne, ne);
                }

            }
            Console.WriteLine(epq.Count);
        }


    }
}
