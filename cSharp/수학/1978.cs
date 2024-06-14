using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1978
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int cnt = 0;
            foreach (int i in ints)
            {
                if (i == 1)
                {
                    continue;
                }

                else if (i == 2)
                {
                    cnt++;
                    continue;
                }
                int f = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        f = 1;
                        break;
                    }
                }
                if (f == 1)
                    continue;
                else
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
