using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _10867
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<int> intset = new HashSet<int>();
            foreach(int i in ints)
                intset.Add(i);
            int[] ans = intset.ToArray();
            Array.Sort(ans);
            Console.Write(string.Join(" ", ans));
                
        }
    }
}
