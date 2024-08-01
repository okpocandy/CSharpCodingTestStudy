using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1427
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            var a = num.ToArray();
            Array.Sort(a);
            var rea = a.Reverse();
            Console.WriteLine(string.Join("", rea));
        }
    }
}
