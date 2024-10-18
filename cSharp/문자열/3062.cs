using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _3062
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++)
            {
                string s= Console.ReadLine();
                string rs = new string(s.Reverse().ToArray());

                int n = int.Parse(s) + int.Parse(rs);
                string ans = n.ToString();
                string rans = new string(ans.Reverse().ToArray());
                if (ans == rans)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
