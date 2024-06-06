using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _4101
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (ab[0] == 0 && ab[1] == 0) { break; }
                if (ab[0] > ab[1])
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            

        }
    }
}
