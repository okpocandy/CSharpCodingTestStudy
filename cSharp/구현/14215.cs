using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _14215
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints);
            int sum = ints[0] + ints[1];
            if (ints[2] < sum)
            {
                Console.WriteLine(sum + ints[2]);
            }
            else
            {
                Console.WriteLine(sum + sum-1);
            }
        }
    }
}
