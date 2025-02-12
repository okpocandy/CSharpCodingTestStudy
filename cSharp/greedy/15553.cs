using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _15553
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int[] difs = new int[n - 1];
            List<int> ls = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ls.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n - 1; i++)
            {
                difs[i] = ls[i + 1] - ls[i];
            }
            Array.Sort(difs);
            Console.WriteLine(difs[0..(n - k)].Sum() + k);
        }
    }
}
