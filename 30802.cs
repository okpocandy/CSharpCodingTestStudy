using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _30802
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] siz = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] tp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int t = tp[0];
            int p = tp[1];

            int ansT = 0;
            foreach (var i in siz)
            {
                if (i % t == 0)
                    ansT += i / t;
                else
                    ansT += i / t + 1;
            }
            Console.WriteLine(ansT);
            Console.WriteLine($"{n/p} {n%p}");
        }
    }
}
