using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _13164
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int[] kids = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> ls = new List<int>();
            for (int i = 0; i < n - 1; i++)
            {
                ls.Add(kids[i + 1] - kids[i]);
            }
            
            ls.Sort();
            int[] ints = ls.ToArray();
            
            Console.WriteLine(ints[0..(n-k)].Sum());
        }
    }
}
