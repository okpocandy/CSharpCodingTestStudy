using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조
{
    internal class _1302
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (dic.ContainsKey(s))
                    dic[s]++;
                else
                    dic[s] = 1;
            }
            var sortedDic = dic.OrderByDescending(entry => entry.Value)
                               .ThenBy(entry => entry.Key);
            Console.WriteLine(sortedDic.ToArray()[0].Key);

        }
    }
}
