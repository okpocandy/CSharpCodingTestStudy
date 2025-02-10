using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _2212
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] sensors = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(sensors);
            List<int> ls = new List<int>();
            for(int i=0; i<n-1; i++)
            {
                ls.Add(Math.Abs(sensors[i+1] - sensors[i]));
            }
            ls.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine(ls.Skip(k - 1).Sum());

        }
    }
}
