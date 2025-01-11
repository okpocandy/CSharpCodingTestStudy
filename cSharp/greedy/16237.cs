using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _16237
    {
        static void Main(string[] args)
        {
            // 바구니에는 최대 5kg
            // 필요바구니 최소
            //    12345
            int[] abcde = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int ans = 0;
            ans += abcde[4];
            ans += abcde[3];
            abcde[0] -= abcde[3];
            ans += abcde[2];
            while (abcde[2] > 0)
            {
                if (abcde[1] > 0)
                    abcde[1]--;
                else if (abcde[0] > 0)
                {
                    abcde[0] -= 2;
                }
                abcde[2]--;
            }
            int tmp = abcde[1] / 2;
            ans += tmp;
            abcde[1] -= tmp*2;
            abcde[0] -= tmp;
            if (abcde[1] == 1)
            {
                ans++;
                abcde[0] -= 3;
            }
            if (abcde[0] > 0)
                ans += (abcde[0] + 4) / 5;
            Console.WriteLine(ans);
        }
    }
}
