using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _4673
    {
        static void Main(string[] args)
        {
            string[] ans = Console.ReadLine().Split();
            string a = ans[0];
            string b = ans[1];
            string ra = new string(a.Reverse().ToArray());
            string rb = new string(b.Reverse().ToArray());
            int ia = int.Parse(ra);
            int ib = int.Parse(rb);

            Console.WriteLine(Math.Max(ia, ib));
        }
        
    }
}
