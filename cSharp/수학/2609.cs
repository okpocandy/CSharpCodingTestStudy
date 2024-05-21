using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _2609
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ab);
            int a = ab[0];
            int b = ab[1];
            int r = 987654321;
            while (true)
            {
                r = b % a;
                if (r == 0)
                    break;
                b = a;
                a = r;
            }
            Console.WriteLine(a);
            Console.WriteLine(ab[0] * ab[1] / a);
        }

    }
}
