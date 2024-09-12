using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조
{
    internal class _1269
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ab[0];
            int b = ab[1];
            int[] ai = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] bi = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<int> ah = new HashSet<int>();
            HashSet<int> bh = new HashSet<int>();
            HashSet<int> tmp = new HashSet<int>();
            foreach (int i in ai)
            {
                ah.Add(i);
                tmp.Add(i);
            }
            foreach (int i in bi)
            {
                bh.Add(i);
            }
            ah.IntersectWith(bh);
            Console.WriteLine(tmp.Count + bh.Count - 2 * ah.Count);
        }
    }
}
