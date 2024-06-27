using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _18870
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] cop = new int[ints.Length];
            ints.CopyTo(cop, 0);
            var dis = cop.Distinct().ToArray();
            Array.Sort(dis);
            StringBuilder sb = new StringBuilder();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < dis.Length; i++)
            {
                dic[dis[i]] = i;
            }
            foreach (int i in ints)
            {
                sb.Append(dic[i] + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
