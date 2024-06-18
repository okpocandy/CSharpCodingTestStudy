using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2231
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[1000054];
            for (int i = 1; i < 1000001; i++)
            {
                var a = i.ToString().ToArray();
                int[] aint = Array.ConvertAll(a, c => (int)char.GetNumericValue(c));
                int sum = i + aint.Sum();

                if (ints[sum] != 0)
                {
                    ints[sum] = Math.Min(i, ints[sum]);
                }
                else
                    ints[sum] = i;
            }
            Console.WriteLine(ints[n]);
        }
    }
}
