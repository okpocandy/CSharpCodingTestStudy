using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2438
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string ans = "";
            for (int i = 0; i < input; i++)
            {
                ans += "*";
                Console.WriteLine(ans);
            }
        }

    }
}
