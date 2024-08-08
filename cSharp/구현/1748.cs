using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1748
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double cnt = 0;
            string s = n.ToString();
            int len = s.Length;
            int index = 1;
            while (index <= len - 1)
            {
                cnt += index * 9 * Math.Pow(10, index - 1);
                index++;
            }
            Console.WriteLine(cnt + (n - Math.Pow(10, index - 1) + 1) * index);
        }
    }
}
