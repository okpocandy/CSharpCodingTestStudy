using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1449
    {
        static void Main(string[] args)
        {
            int[] nl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nl[0];
            int l = nl[1];

            int[] ls = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ls);
            int index = 1;
            int st = ls[0];
            int cnt = 0;
            while (true)
            {
                if (index >= ls.Length)
                    break;
                if (ls[index] <= st + l - 1)
                {
                    index++;
                }
                else
                {
                    cnt++;
                    st = ls[index];
                    index++;
                }

            }
            Console.WriteLine(cnt + 1);
        }
    }
}
