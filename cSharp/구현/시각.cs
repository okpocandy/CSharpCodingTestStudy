using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 시각
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for(int i=0; i<=n;  i++)
            {
                for(int j=0; j<60;  j++)
                {
                    for(int k=0; k<60; k++)
                    {
                        string h = i.ToString();
                        string m = j.ToString();
                        string s = k.ToString();
                        if (h.Contains("3") || m.Contains("3") || s.Contains("3"))
                            ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

/*
 
입력:
5

정답:
11475

 */
