using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _11655
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string ans = "";
            StringBuilder sb = new StringBuilder();
            foreach(var s in a)
            {
                char sc = s;
                if(char.IsDigit(s))
                {
                    sb.Append(sc);
                    continue;
                }
                    
                else
                {
                    int si = (int)s + 13;
                    if (char.IsUpper(s))
                    {
                        
                        if(si > 90)
                        {
                            si -= 26;
                        }
                        sc = (char)si;
                    }
                    else if(char.IsLower(s))
                    {
                        if (si > 122)
                        {
                            si -= 26;
                        }
                        sc = (char)si;
                    }
                }
                sb.Append(sc);
                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
