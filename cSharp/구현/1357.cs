using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class _1357
    {
        static void Main(string[] args)
        {
            string[] xy = Console.ReadLine().Split();
            string x = xy[0];
            string y = xy[1];
            string rx = new string(x.Reverse().ToArray());
            string ry = new string(y.Reverse().ToArray());
            int irx = int.Parse(rx);
            int iry = int.Parse(ry);
            string ans = new string((irx + iry).ToString().Reverse().ToArray());
            Console.WriteLine(int.Parse(ans));
        }
    }
}
