using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _10250
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int[] HWN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int H = HWN[0];
                int W = HWN[1];
                int N = HWN[2];
                int a = N % H;
                int b = N / H;
                if (a == 0) { a = H; }
                else
                    b += 1;
                Console.WriteLine($"{a}{b:00}");
            }
        }
    }
}
