using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1735
    {
        static void Main(string[] args)
        {
            int[] aab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int at = aab[0];
            int ab = aab[1];
            int[] bab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int bt = bab[0];
            int bb = bab[1];
            int b = ab * bb / gcd(ab, bb);
            int t = at * (b / ab) + bt * (b / bb);

            int tmp = Math.Min(t, b);
            int index = 2;
            while (index <= tmp)
            {
                while (b % index == 0 && t % index == 0)
                {
                    b = b / index;
                    t = t / index;
                }
                index++;
            }
            Console.WriteLine(t + " " + b);
        }
        static int gcd(int n, int m)
        {
            if (m == 0) return n;
            else
                return gcd(m, n % m);
        }
    }
}
