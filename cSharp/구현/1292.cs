using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1292
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ab[0];
            int b = ab[1];
            int[] ints = new int[1001];
            int cnt = 0;
            for (int i = 1; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ints[cnt++] = i;
                    if (cnt == b)
                        break;
                }
                if (cnt == b)
                    break;
            }
            Console.WriteLine(ints[(a - 1)..b].Sum());
        }
    }
}
