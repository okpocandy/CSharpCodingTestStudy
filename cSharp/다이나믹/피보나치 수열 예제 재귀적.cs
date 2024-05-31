using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 피보나치_수열_예제_재귀적
    {
        static long[] d = new long[100];
        static void Main(string[] args)
        {
            
            Console.WriteLine(Fibo(10));
        }
        static long Fibo(int x)
        {
            if (x == 1 || x == 2)
                return 1;
            if (d[x] != 0)
                return d[x];
            d[x] = Fibo(x - 1) + Fibo(x - 2);
            return d[x];
        }
    }
}
