using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.그리디
{
    internal class _28014
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] tower = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int index = 1;
            int comp = tower[0];
            int count = 1;

            while( index != N)
            {
                if (tower[index] >= comp)
                {
                    count++;
                }
                comp = tower[index];
                index++;
            }

            Console.WriteLine(count);
        }
    }
}
