using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _1이_될_때까지
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int ans = 0;
            while (n > 1)
            {
                if (n % k == 0)
                    n = n / k;
                else
                    n -= 1;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}

/*

입력:
25 5

정답:
2

 
 */