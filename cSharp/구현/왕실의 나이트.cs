using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 왕실의_나이트
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int x = (int)input[0] - 96;
            int y = (int)input[1] - 48;
            int[,] steps = new int[8, 2] { { -2, -1 }, { 2, -1 }, { -2, 1 }, { 2, 1 }, { 1, 2 }, { -1, -2 }, { 1, -2 }, { -1, 2 } };
            int count = 0;
            for(int i=0; i<steps.GetLength(0); i++)
            {
                int dx = x;
                int dy = y;
                dx += steps[i, 0];
                dy += steps[i, 1];
                if(dx < 1 || dy < 1 || dx > 8 || dy > 8)
                    continue;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
