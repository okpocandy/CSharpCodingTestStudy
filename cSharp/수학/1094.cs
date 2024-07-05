using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1094
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 64;
            int sum = 0;
            int cnt = 1;
            while (true)
            {
                if (a == n) { break; }
                if (a / 2 >= n)
                {
                    a = a / 2;
                    if (a == n) { break; }
                    continue;
                }
                int tmp = a / 2;
                sum += tmp;
                if (sum == n) { break; }
                if (sum >= n)
                {
                    sum -= tmp;
                    a = tmp;
                }
                else
                {
                    a = tmp;
                    cnt++;
                }


            }
            Console.WriteLine(cnt);
        }
    }
}
