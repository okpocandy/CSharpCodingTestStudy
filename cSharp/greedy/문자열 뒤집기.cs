using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 문자열_뒤집기
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int tmp0 = 0;
            int tmp1 = 0;
            bool eq = false;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '0')
                    eq = false;
                else
                {
                    if(eq == false)
                    {

                        tmp0++;
                        eq = true;
                    }
                }
            }
            eq = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                    eq = false;
                else
                {
                    if (eq == false)
                    {

                        tmp1++;
                        eq = true;
                    }
                }


            }
            Console.WriteLine(Math.Min(tmp0, tmp1));
        }
    }
}
