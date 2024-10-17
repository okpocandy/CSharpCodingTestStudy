using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1371
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                foreach(char c in line)
                {
                    if(char.IsLower(c))
                    {
                        if (dic.ContainsKey(c))
                            dic[c]++;
                        else
                            dic[c] = 1;
                    }
                    
                }
            }
            int maxc = dic.Values.Max();
            var result = from item in dic
                         where item.Value == maxc
                         orderby item.Key
                         select item.Key;
            string ans = "";
            foreach(char c in result)
            {
                if (c != ' ')
                    ans += c;
            }
            Console.WriteLine(ans);

            
        }
    }
}
