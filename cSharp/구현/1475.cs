using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1475
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                dic[i] = 0;
            }
            foreach(var a in s)
            {
                dic[(int)a-(int)'0']++;
            }
            if (dic[9] > dic[6])
            {
                int tmp = (dic[9] - dic[6]) / 2;
                dic[9] -= tmp;
                dic[6] += tmp;
            }
            else
            {
                int tmp = (dic[6] - dic[9]) / 2;
                dic[6] -= tmp;
                dic[9] += tmp;
            }
            Console.WriteLine(dic.Values.Max());
        }
    }
}
