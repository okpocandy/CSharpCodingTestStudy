using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1254
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int ans = 0;
            for(int i=0; i<s.Length; i++)
            {
                string subStr = s[i..];  // 부분 문자열
                string reversedSubStr = new string(subStr.Reverse().ToArray());  // 뒤집기
                if (subStr == reversedSubStr)
                {
                    ans = s.Length - i;
                    break;
                } 
            }
            Console.WriteLine((s.Length-ans) * 2 + ans);
        }
    }
}
