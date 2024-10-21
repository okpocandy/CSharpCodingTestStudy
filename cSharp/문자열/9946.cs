using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _9946
    {
        static void Main(string[] args)
        {
            int index = 1;
            while(true)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                if (a == "END" && b == "END")
                    break;
                char[] ca = a.ToCharArray();
                char[] cb = b.ToCharArray();
                Array.Sort(ca);
                Array.Sort(cb);
                string sa = new string(ca);
                string sb = new string(cb);
                if (sa == sb)
                    Console.WriteLine($"Case {index}: same");
                else
                    Console.WriteLine($"Case {index}: different");
                index++;
            }
        }
    }
}
