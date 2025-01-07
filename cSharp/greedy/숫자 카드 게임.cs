using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 숫자_카드_게임
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int ans = 0;
            for(int i=0; i<n; i++)
            {
                var ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ans = Math.Max(ans, ints.Min());
            }
            Console.WriteLine(ans);
        }
    }

    
}
/*
     
입력:
3 3
3 1 2
4 1 4
2 2 2

정답:
2

입력:
2 4
7 3 1 8
3 3 3 4

정답:
3
     
     
*/
