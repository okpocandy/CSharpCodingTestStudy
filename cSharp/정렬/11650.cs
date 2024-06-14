using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _11650
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)> ints = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ints.Add((a[0], a[1]));
            }
            ints.Sort((a, b) =>
            {
                if (a.Item1 > b.Item1)
                    return 1;
                else if (a.Item1 < b.Item1)
                    return -1;
                else
                {
                    if (a.Item2 > b.Item2)
                        return 1;
                    else 
                        return -1;
                }

            });
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ints.Count; i++)
            {
                sb.Append(ints[i].Item1 + " " + ints[i].Item2 + "\n");

            }
            Console.WriteLine(sb);
        }
    }
}
