using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1065
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i < 100)
                {
                    cnt++;
                    continue;
                }
                else if (i < 1000)
                {
                    int tmp = i;
                    int a = i / 100;
                    tmp -= a * 100;
                    int b = tmp / 10;
                    tmp -= b * 10;
                    int c = tmp;
                    if (a - b == b - c)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
