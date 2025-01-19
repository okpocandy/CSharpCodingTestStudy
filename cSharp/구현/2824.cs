using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2824
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            BigInteger am = 1;
            BigInteger bm = 1;
            for (int i = 0; i < n; i++)
            {
                am *= a[i];
            }
            for (int i = 0; i < m; i++)
            {
                bm *= b[i];
            }
            BigInteger ans = Gcd(am, bm);
            string ansStr = ans.ToString();
            if (ansStr.Length > 9)
            {
                ansStr = ansStr.Substring(ansStr.Length - 9);
            }
            Console.WriteLine($ansStr);

        }

        static BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger c = b;

                b = a % b;
                a = c;
            }
            return a;
        }
    }
}
