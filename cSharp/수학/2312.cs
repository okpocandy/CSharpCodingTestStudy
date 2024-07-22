using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _2312
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int d = 2;
                int cnt = 0;
                while (n != 1)
                {
                    if (n % d == 0)
                    {
                        n = n / d;
                        cnt++;
                    }
                    else
                    {
                        if (cnt != 0)
                        {
                            sb.Append(d + " " + cnt + "\n");

                            cnt = 0;
                        }
                        d++;
                    }
                }
                if (cnt != 0)
                {
                    sb.Append(d + " " + cnt + "\n");
                    cnt = 0;
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
