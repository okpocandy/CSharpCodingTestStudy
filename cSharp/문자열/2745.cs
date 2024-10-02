using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _2745
    {
        static void Main(
            string[] args)
        {
            string[] tmp = Console.ReadLine().Split();
            int b = int.Parse(tmp[1]);
            List<int> ls = new List<int>();
            foreach(var i in tmp[0])
            {
                if ((int)i >= (int)'A')
                    ls.Add((int)i - (int)'7');
                else
                    ls.Add((int)i - 48);

            }
            double ans = 0;
            int index = ls.Count-1;
            foreach (var i in ls)
            {
                ans += i * Math.Pow(b, index--);
            }
            Console.WriteLine(ans);
        }
    }
}
