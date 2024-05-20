using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _4153
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0)
                    break;
                int max_ints = ints.Max();
                Array.Sort(ints);
                if (ints[2] * ints[2] == ints[1] * ints[1] + ints[0] * ints[0])
                    Console.WriteLine("right");
                else
                    Console.WriteLine("wrong");
            }

        }
    }
}
