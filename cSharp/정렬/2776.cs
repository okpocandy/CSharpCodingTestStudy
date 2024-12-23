using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2776
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] asu = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] bsu = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(asu);
            Array.Sort(bsu);
            int aind = 0;
            int bind = 0;
            int[] ans = new int[m];
            while(aind < n)
            {
                if (bsu[bind] > asu[aind])
                {
                    ans[bind] = 0;
                }
                else if(bsu[bind] < asu[aind])
                {
                    aind++;
                }
                else
                {
                    ans[bind] = 1;
                    aind++;
                    bind++;
                }
            }
            foreach(int i in ans)
            {
                Console.WriteLine(i);
            }
        }
    }
}
