using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _1225
    {
        static void Main(string[] args)
        {
            string[] ss = Console.ReadLine().Split();
            string a= ss[0];
            string b= ss[1];
            long ans = 0;
            for(int i=0; i<a.Length; i++)
            {
                for(int j=0; j<b.Length; j++)
                {
                    ans += int.Parse(a[i].ToString())
                            * int.Parse(b[j].ToString());
                }
            }
            Console.WriteLine(ans);

        }
    }
}
