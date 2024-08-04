using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1476
    {
        static void Main(string[] args)
        {
            int[] esm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int e = esm[0];
            int s = esm[1];
            int m = esm[2];
            for(int i=1; i<987654321;i++)
            {
                if((i-e) % 15 == 0 && (i-s) % 28 == 0 && (i-m) % 19 ==0)
                {
                    Console.WriteLine(i);
                    break;
                }

            }
        }
    }
}
