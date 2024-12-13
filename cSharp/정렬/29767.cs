using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _29767
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<long> ls = new List<long>();
            long tmp = 0;
            foreach(var score  in scores)
            {
                tmp += score;
                ls.Add(tmp);
            }
            ls.Sort( (x,y) => y.CompareTo(x));
            long ans = 0;
            for (int i = 0; i < k; i++)
                ans += ls[i];
            Console.WriteLine(ans);
        }
    }
}
