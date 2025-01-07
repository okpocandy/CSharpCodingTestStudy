using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 큰_수의_법칙
    {
        static void Main(string[] args)
        {
            int[] nmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nmk[0];
            int m = nmk[1];
            int k = nmk[2];
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints, (a,b) => b.CompareTo(a));
            int tmp = m % (k + 1);
            int ans = (m / (k + 1)) * (ints[0] * k + ints[1]) + ints[0] * tmp;
            Console.WriteLine(ans);
        }

        /*
         입력:
        2 8 3
        2 4 5 4 6

        정답:
        46
         
         
         
         
         */

    }
}
