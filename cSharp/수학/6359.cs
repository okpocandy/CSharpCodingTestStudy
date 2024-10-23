using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    class _6359
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                int a = 3;
                while (tmp >= a * a)
                {
                    a++;
                }
                Console.WriteLine(a - 1);
            }
        }
    }
}
