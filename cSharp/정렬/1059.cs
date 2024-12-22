using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1059
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int[] s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            int index = 0;
            int left = 0;
            int right = 0;
            Array.Sort(s);
            if (s.Contains(n))
                ans = 0;
            else
            {
                for(int i=0; i<s.Length-1; i++)
                {
                    if (s[i] < n)
                    {
                        left = s[i];
                        right = s[i + 1];
                    }
                    else
                        break;
                }
                if (left == 0)
                    right = s[0];
                int tmp = (right - n) * (n - (left + 1));
                ans += tmp;
                ans += right - n - 1;
                
            }
            Console.WriteLine(ans);

        }
    }
}
