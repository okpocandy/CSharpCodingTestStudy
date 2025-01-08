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
            string xy = Console.ReadLine();
            (int y, int x)[] steps = { (-2, -1), (-1, -2), (1, -2), (2, -1), (2, 1), (1, 2), (-1, 2), (-2, 1) };
            int ans = 0;
            int x = (int)xy[0] - (int)'a' + 1;
            int y = (int)xy[1] - (int)'1' + 1;
            Console.WriteLine(x + " " + y);
            foreach (var step in steps)
            {
                int tmpx = x + step.x;
                int tmpy = y + step.y;
                if (tmpx < 1 || tmpy < 1 || tmpx > 8 || tmpy > 8)
                    continue;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}

/*

입력:
a1

정답:
2
 
 */
