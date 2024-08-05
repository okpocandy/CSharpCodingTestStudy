using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp
{
    internal class _2003
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int left = 0;
            int right = 1;
            int cnt = 0;
            while(left<n && right<=n)
            {
                int tmp = ints[left..right].Sum();
                if (tmp < m)
                    right++;
                else if (tmp > m)
                    left++;
                else
                {
                    cnt++;
                    left++;
                    right++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
