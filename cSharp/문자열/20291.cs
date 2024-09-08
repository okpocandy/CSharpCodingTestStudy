using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _20291
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string s = Console.ReadLine();
                int a = s.IndexOf('.') + 1;
                string se = s[a..^0];
                if (dic.ContainsKey(se))
                    dic[se]++;
                else
                    dic[se] = 1;
            }
            var x = dic.OrderBy(x => x.Key);
            foreach(var i in x)
            {
                sb.AppendLine(i.Key + " " + i.Value);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
