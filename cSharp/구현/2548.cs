using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2548
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int mins = 987654321;
            int mina = 1;
            for (int i = 1; i < ints.Max() + 1; i++)
            {
                int sm = 0;
                for (int j = 0; j < ints.Length; j++)
                {
                    sm += Math.Abs(i - ints[j]);
                }
                if (sm < mins)
                {
                    mins = sm;
                    mina = i;
                }
                else if (sm == mins)
                {
                    if (i <= mina)
                        mina = i;
                }


            }
            Console.WriteLine(mina);
        }
    }
}
