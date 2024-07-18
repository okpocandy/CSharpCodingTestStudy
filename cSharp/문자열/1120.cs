using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1120
    {
        static void Main(string[] args)
        {
            var inp = Console.ReadLine().Split();
            string a = inp[0];
            string b = inp[1];
            int dif = b.Length - a.Length;
            int min_cnt = 50;
            for (int i = 0; i <= dif; i++)
            {
                int cnt = 0;
                string tmp = b[i..(i + a.Length)];
                for (int j = 0; j < tmp.Length; j++)
                {
                    if (a[j] != tmp[j])
                    {
                        cnt++;
                    }
                }
                min_cnt = Math.Min(min_cnt, cnt);
            }
            Console.WriteLine(min_cnt);
        }
    }
}
