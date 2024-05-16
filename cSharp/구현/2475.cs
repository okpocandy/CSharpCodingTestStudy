using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2475
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine((ints[0] * ints[0] + ints[1] * ints[1] + ints[2] * ints[2] + ints[3] * ints[3] + ints[4] * ints[4]) % 10);
        }
    }
}
