using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _4344
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < c; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int n = ints[0];
                int[] arr = ints[1..];
                double avr = (double)arr.Sum() / n;
                double cnt = arr.Count(x => x > avr);
                double ans = cnt / n * 100;
                sb.Append(Math.Round(ans, 3).ToString("F3") + '%' + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
