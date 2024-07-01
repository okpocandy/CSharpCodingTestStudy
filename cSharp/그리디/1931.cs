using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1931
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)> ls = new List<(int, int)>();
            for (int i=0; i<n; i++)
            {
                int[] inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ls.Add((inp[0], inp[1]));
            }
            ls.Sort((a,b) =>
            {
                if(a.Item2 == b.Item2)
                    return a.Item1.CompareTo(b.Item1);
                else
                    return a.Item2.CompareTo(b.Item2);
            });
            int st = 0;
            int ed = 0;
            int cnt = 0;
            foreach(var i in ls)
            {
                if(i.Item1 >= ed)
                {
                    st = i.Item1;
                    ed = i.Item2;
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
