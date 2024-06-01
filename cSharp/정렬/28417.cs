using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _28417
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max_res = 0;
            for (int i = 0; i < n; i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] run = inputs[0..2];
                int[] trick = inputs[2..7];
                Array.Sort(trick);
                int result = run.Max() + trick[4] + trick[3];
                max_res = Math.Max(result, max_res);
            }
            Console.WriteLine(max_res);
        }
    }
}
