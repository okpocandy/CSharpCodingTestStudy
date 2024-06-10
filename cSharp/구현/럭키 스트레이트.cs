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
            string inp = Console.ReadLine();
            int suml = 0;
            int sumr = 0;
            for(int i=0; i<inp.Length/2; i++)
                suml += (int)(inp[i]) - (int)'0';
            for (int i = inp.Length / 2; i < inp.Length; i++)
                sumr += (int)(inp[i]) - (int)'0';
            if (sumr == suml)
                Console.WriteLine("LUCKY");
            else
                Console.WriteLine("READY");
        }
    }
}
/*

inp:
123402

out:
LUCKY

inp:
7755

out:
READY
 */
