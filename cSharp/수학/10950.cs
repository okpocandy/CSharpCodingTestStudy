using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _10950
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for(int i = 0; i < test; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Console.WriteLine(ints[0] + ints[1]);
            }
        }
    }
}
