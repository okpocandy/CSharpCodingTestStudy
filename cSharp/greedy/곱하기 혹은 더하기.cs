using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 곱하기_혹은_더하기
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int ans = s[0] - '0';
            for(int i=1; i<s.Length; i++)
            {
                int tmp = s[i] - '0';
                if (ans == 0 || ans == 1)
                    ans += tmp;
                else
                {
                    if (tmp == 0 || tmp == 1)
                        ans += tmp;
                    else
                        ans *= tmp;
                }
                
            }
            Console.WriteLine(ans);
        }
    }
}


/*

입력:
02984

출력:
576

입력:
567

출력:
210
 

 */