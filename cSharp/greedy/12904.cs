using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _12904
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            while(t.Length != s.Length)
            {
                if (t[t.Length - 1] == 'B')
                {
                    t = t.Substring(0, t.Length - 1);
                    t = string.Join("", t.Reverse());
                }
                else
                {
                    t = t.Substring(0, t.Length - 1);
                }
            }
            if (s.Equals(t))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
