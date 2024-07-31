using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1003
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[,] ints = new int[41, 2];
            ints[0, 0] = 1;
            ints[0, 1] = 0;
            ints[1, 0] = 0;
            ints[1, 1] = 1;
            for(int i=2; i<=40;  i++)
            {
                ints[i, 0] = ints[i - 1, 0] + ints[i - 2, 0];
                ints[i,1] = ints[i - 1, 1] + ints[i - 2, 1];
            }
            for(int i=0; i<t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(ints[n,0] + " " + ints[n,1]);
            }
        }

    }
}
