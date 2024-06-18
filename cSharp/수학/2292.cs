using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2292
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = 1;
            int cnt = 1;
            while(a< n)
            {
                sum += 6;
                cnt++;
                a += sum;
            }
            Console.WriteLine(cnt);
        }
    }
}
