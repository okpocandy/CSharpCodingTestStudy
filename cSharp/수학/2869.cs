using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _2869
    {
        static void Main(string[] args)
        {
            int[] abv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = abv[0];
            int b = abv[1];
            int v = abv[2];
            int tmp = a - b;
            v -= a;
            int ans = 1;
            if (v <= 0) { Console.WriteLine(1); }
            else
            {
                ans += v / tmp;
                if (v % tmp != 0)
                    ans++;
                Console.WriteLine(ans);
            }
        }
    }
}
