using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _25193
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int cnt = 0;
            int ch = 0;
            foreach(var c in s)
            {
                if (c != 'C')
                    cnt++;
                else
                    ch++;

            }
            if (ch % (cnt + 1) != 0) Console.WriteLine(ch / (cnt + 1) + 1);
            else Console.WriteLine(ch / (cnt + 1));
        }
    }
}
