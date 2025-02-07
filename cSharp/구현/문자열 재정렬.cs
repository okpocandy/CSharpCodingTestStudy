using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 문자열_재정렬
    {
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            string ans = "";
            int ai = 0;
            foreach(var s in ss)
            {
                if (char.IsDigit(s))
                    ai += s - '0';
                else
                    ans += s;
            }
            var arrans = ans.ToCharArray();
            Array.Sort(arrans);
            Console.WriteLine(string.Join("", arrans) + ai);
        }
    }
}

/*
 
입력:
K1KA5CB7

출력:
ABCKK13

입력:
AJKDLSI412K4JSJ9D

출력:
ADDIJJJKKLSS20
 
 */