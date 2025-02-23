using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _20117
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints);
            int ans = 0;
            if(ints.Length % 2 == 0)
            {
                for (int i = ints.Length / 2; i < n; i++)
                    ans += ints[i];
                ans *= 2;
            }
            else
            {
                for (int i = ints.Length / 2 + 1; i < n; i++)
                    ans += ints[i];
                ans *= 2;
                ans += ints[ints.Length / 2];
            }
            Console.WriteLine(ans);
        }
    }
}
