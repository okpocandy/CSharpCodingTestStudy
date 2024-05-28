using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.그리디
{
    internal class _30019
    {
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] classes = new int[NM[0],2];

            StringBuilder sb = new StringBuilder();
            
            for(int i=0; i < NM[1]; i++)
            {
                int[] kse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if ( classes[kse[0]-1,1] <= kse[1])
                {
                    sb.Append("YES\n");
                    classes[kse[0] - 1, 0] = kse[1];
                    classes[kse[0] - 1, 1] = kse[2];
                }
                else
                {
                    sb.Append("NO\n");
                }

            }
            Console.WriteLine(sb);
        }
    }
}
