using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 럭키_스트레이트
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int mid = n.Length / 2;
            string s1 = n[0..mid];
            string s2 = n[mid..];
            int tmp1 = 0;
            int tmp2 = 0;
            foreach(var s in s1)
            {
                tmp1 += s - '0';
            }
            foreach(var s in s2)
            {
                tmp2 += s - '0';
            }
            if (tmp1 == tmp2)
                Console.WriteLine("LUCKY");
            else
                Console.WriteLine("READY");
        }
    }
}
