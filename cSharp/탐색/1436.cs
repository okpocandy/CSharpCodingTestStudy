using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _1436
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int ans = 0;
            int i = 666;
            while (true)
            {
                if (i.ToString().Contains("666"))
                    ans++;
                if (ans == num)
                {
                    Console.WriteLine(i);
                    break;
                }
                i++;
            }
        }
    }
}
