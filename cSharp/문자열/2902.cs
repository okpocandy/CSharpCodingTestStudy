using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _2902
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split('-');
            StringBuilder sb = new StringBuilder();
            foreach (var i in s)
                sb.Append(i[0]);
            Console.WriteLine(sb.ToString());
        }
    }
}
