using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _18110
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            for(int i=0; i<ints.Length; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            double a = n * 0.15;
            int intA = 0;
            if (a - (int)a >= 0.5)
                intA = (int)a + 1;
            else
                intA = (int)a;
            Array.Sort(ints);
            if (n == 0)
                Console.WriteLine(0);
            else
            {
                ints = ints[intA..(n-intA)];
                double ans = (double)ints.Sum() / (double)(n-(2* intA));
                int intAns = 0;
                if (ans - (int)ans >= 0.5)
                    intAns = (int)ans + 1;
                else
                    intAns = (int)ans;
                Console.WriteLine(intAns);
            }
            
        }
    }
}
