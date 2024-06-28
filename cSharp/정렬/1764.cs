using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1764
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            Dictionary<string, int> ls = new Dictionary<string, int>();
            List<string> ans = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                ls[s] = 1;
            }
            for (int i = 0; i < m; i++)
            {
                string s = Console.ReadLine();
                if (ls.ContainsKey(s))
                    ans.Add(s);
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(ans.Count + "\n");
            ans.Sort();
            foreach (string s in ans)
            {
                sb.Append(s + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
