using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1251
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ans = "";
            for (int i = 0; i < s.Length; i++)
                ans += "z";
            for (int i = 1; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    string tmp1 = s[0..i];
                    string tmp2 = s[i..j];
                    string tmp3 = s[j..];
                    string rtmp1 = new string(tmp1.Reverse().ToArray());
                    string rtmp2 = new string(tmp2.Reverse().ToArray());
                    string rtmp3 = new string(tmp3.Reverse().ToArray());
                    string tmpsum = rtmp1 + rtmp2 + rtmp3;
                    if (string.Compare(tmpsum, ans) <= 0)
                    {
                        ans = tmpsum;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
