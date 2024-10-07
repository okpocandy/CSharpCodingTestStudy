using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _1032
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ls = new List<string>();
            for(int i=0; i<n; i++)
            {
                ls.Add(Console.ReadLine());
            }
            string ans = "";
            for(int i=0; i < ls[0].Length; i++)
            {
                char c = ls[0][i];
                foreach(var s in ls)
                {
                    if(c == s[i])
                    {
                        continue;
                    }
                    else
                    {
                        c = '?';
                        break;
                    }
                }
                ans += c;
            }
            Console.WriteLine(ans);
        }
    }
}
