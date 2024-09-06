using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _10988
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string a = new string(s.Reverse().ToArray());
            if (a == s)
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(0);
        }
    }
}
