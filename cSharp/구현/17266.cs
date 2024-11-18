using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _17266
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int l = ints[0];
            int r = n - ints[^1];
            int mid = 0;
            HashSet<int> s = new HashSet<int>();
            if(ints.Length >= 2)
            {
                for(int i=0; i<ints.Length-1; i++)
                {
                    int tmp = ints[i+1] - ints[i];
                    s.Add(tmp);
                }
                mid = s.Max();
                if (mid % 2 == 0)
                    mid /= 2;
                else
                    mid = mid / 2 + 1;
            }
            int ans = new[] {l, r, mid}.Max();
            Console.WriteLine(ans);
        }
    }
}
