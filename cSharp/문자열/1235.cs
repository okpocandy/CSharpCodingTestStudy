using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1235
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ls = new List<string>();
            for(int i=0; i<n; i++)
            {
                ls.Add(Console.ReadLine());  
            }
            int len = ls[0].Length;
            int ans = len;
            List<string> tmp = new List<string>();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var a = ls[j][(len - i-1)..];
                    if (!tmp.Contains(a))
                        tmp.Add(a);
                    else
                        break;
                    if(j==n-1)
                    {
                        ans = i;
                        break;
                    }    
                }
                if (ans != len)
                    break;
                    
            }
            Console.WriteLine(ans+1);
        }
    }
}
