using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1431
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ls = new List<string>();
            for (int i = 0; i < n; i++)
            {
                ls.Add(Console.ReadLine());
            }
            ls.Sort((x, y) =>
            {
                if (x.Length < y.Length)
                    return -1;
                else if (x.Length > y.Length)
                    return 1;
                else
                {
                    string tmpx = Regex.Replace(x, @"[^0-9]", "");
                    string tmpy = Regex.Replace(y, @"[^0-9]", "");
                    int sumx = 0;
                    int sumy = 0;
                    foreach (var a in tmpx)
                    {
                        sumx += a - '0';
                    }
                    foreach (var b in tmpy)
                    {
                        sumy += b - '0';
                    }
                    if (sumx < sumy)
                        return -1;
                    else if (sumy < sumx)
                        return 1;
                    else
                    {
                        return x.CompareTo(y);
                    }
                }
            });
            foreach (var s in ls)
                Console.WriteLine(s);
        }
    }
}
