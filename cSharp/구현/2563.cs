using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2563
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] ints = new int[101, 101];
            for (int i = 0; i < n; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int x = xy[0] - 1; x < xy[0] + 9; x++)
                {
                    for (int y = xy[1] - 1; y < xy[1] + 9; y++)
                    {
                        ints[y, x] = 1;
                    }
                }
            }
            int ans = 0;
            foreach (var x in ints)
            {
                if (x == 1) { ans++; }
            }
            Console.WriteLine(ans);
        }
    }
}
