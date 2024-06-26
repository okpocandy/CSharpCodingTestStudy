using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조
{
    internal class _17219
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            Dictionary<string, string> dic = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] inp = Console.ReadLine().Split();
                dic[inp[0]] = inp[1];
            }
            for (int i = 0; i < m; i++)
            {
                string inp = Console.ReadLine();
                sb.Append(dic[inp] + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
