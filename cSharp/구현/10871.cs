using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _10871
    {
        static void Main(string[] args)
        {
            int[] NX = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int num in numbers)
            {
                if (NX[1] > num)
                {
                    Console.Write(num + " ");
                }
            }

        }
    }
}
