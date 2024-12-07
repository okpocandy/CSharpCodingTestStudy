using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class _2846
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int bef = ints[0];
            int max = 0;
            if (n == 1)
                Console.WriteLine(0);
            else
            {
                int cnt = 0;
                for(int i=1; i<n; i++)
                {
                    if (ints[i] > bef)
                    {
                        cnt += ints[i] - bef;
                    }
                    else
                    {
                        cnt = 0;
                    }
                    bef = ints[i];
                    max = Math.Max(max, cnt);
                }
                Console.WriteLine(max);
            }
        }
    }
}
