using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _2485
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();   
            for(int i=0; i<n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            List<int> sum = new List<int>();
            for(int i=0; i<n-1; i++)
            {
                sum.Add(list[i + 1] - list[i]);
            }
            int gcd = sum[0];
            for (int i = 1; i < n - 1; i++)
                gcd = Gcd(gcd, sum[i]);
            int cnt = 0;
            for (int i = 0; i < n - 1; i++)
                cnt += (sum[i] / gcd) - 1;
            Console.WriteLine(cnt);
        }

        static private int Gcd(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Gcd(b, a % b);
        }
    }
}
