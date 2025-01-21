using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _15903
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            long[] cards = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            for(int i=0; i<m; i++)
            {
                Array.Sort(cards);
                long tmp = cards[0] + cards[1];
                cards[0] = tmp;
                cards[1] = tmp;
            }
            Console.WriteLine(cards.Sum());
        }
    }
}
