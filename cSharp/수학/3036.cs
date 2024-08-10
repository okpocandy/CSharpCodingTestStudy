using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _3036
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            StringBuilder sb = new StringBuilder();
            int ttmp = 1;
            int btmp = 1;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                int t = ints[i];
                int b = ints[i + 1];
                t = ttmp * t;
                b = btmp * b;
                int index = Math.Min(t, b);
                for (int j = 2; j <= index; j++)
                {
                    while (t % j == 0 && b % j == 0)
                    {
                        t = t / j;
                        b = b / j;
                    }
                }
                ttmp = t;
                btmp = b;
                sb.Append(t + "/" + b + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
