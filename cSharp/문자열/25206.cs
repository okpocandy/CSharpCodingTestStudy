using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _25206
    {
        static void Main(string[] args)
        {
            double score = 0;
            double ans = 0;
            for (int i=0; i<20; i++)
            {
                
                string[] s = Console.ReadLine().Split();
                
                switch(s[2])
                {
                    case "A+":
                        ans += 4.5 * double.Parse(s[1]);
                        break;
                    case "A0":
                        ans += 4.0 * double.Parse(s[1]);
                        break;
                    case "B+":
                        ans += 3.5 * double.Parse(s[1]);
                        break;
                    case "B0":
                        ans += 3.0 * double.Parse(s[1]);
                        break;
                    case "C+":
                        ans += 2.5 * double.Parse(s[1]);
                        break;
                    case "C0":
                        ans += 2.0 * double.Parse(s[1]);
                        break;
                    case "D+":
                        ans += 1.5 * double.Parse(s[1]);
                        break;
                    case "D0":
                        ans += 1.0 * double.Parse(s[1]);
                        break;
                    case "F":
                        ans += 0.0 * double.Parse(s[1]);
                        break;

                }
                if (s[2] != "P")
                    score += double.Parse(s[1]);
            }
            Console.WriteLine((ans/score).ToString("0.000000"));
        }
    }
}
