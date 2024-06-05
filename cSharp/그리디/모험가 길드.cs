using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.그리디
{
    internal class 모험가_길드
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints);
            int res = 0;
            int cnt = 0;

            for(int i=0; i<ints.Length; i++)
            {
                cnt++;
                if (ints[i] <= cnt)
                {
                    res++;
                    cnt = 0;
                }
            }
            Console.WriteLine(res);
        }
    }
}
/*

5
2 3 1 2 2

*/