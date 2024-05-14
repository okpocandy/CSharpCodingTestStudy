using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2562
    {
        static void Main(string[] args)
        {
            int maxNum = 0;
            int maxIndex = 987654321;
            for (int i = 0; i < 9; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                if (tmp > maxNum)
                {
                    maxIndex = i;
                    maxNum = tmp;
                }

            }
            Console.WriteLine(maxNum);
            Console.WriteLine(maxIndex + 1);
        }
    }
}
