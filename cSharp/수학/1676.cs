using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1676
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            int count2 = 0;
            int count5 = 0;
            for (int i = 1; i <= N; i++)
            {
                int a = i;
                while (a % 2 == 0)
                {
                    a = a / 2;
                    count2++;
                }
                while (a % 5 == 0)
                {
                    a = a / 5;
                    count5++;
                }

            }
            Console.WriteLine(Math.Min(count2, count5));
        }

    }
}
