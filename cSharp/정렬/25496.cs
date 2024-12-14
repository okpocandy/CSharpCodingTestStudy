using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _25496
    {
        static void Main(string[] args)
        {
            int[] pn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int p = pn[0];
            int n = pn[1];
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints);
            int cnt = 0;
            while(p < 200)
            {
                p += ints[cnt];
                cnt++;
                if (cnt == n)
                    break;
            }
            Console.WriteLine(cnt);
        }
    }
}
