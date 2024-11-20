using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2628
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int t = int.Parse(Console.ReadLine());
            List<int> zero = new List<int>();
            zero.Add(0);
            zero.Add(m);
            
            List<int> one = new List<int>();
            one.Add(0);
            one.Add(n);
            for(int i=0; i<t; i++)
            {
                int[] tmp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (tmp[0] == 0)
                    zero.Add(tmp[1]);
                else
                    one.Add(tmp[1]);
            }
            zero.Sort();
            one.Sort();
            int ans = 0;
            for(int i=0; i<zero.Count-1; i++)
            {
                int height = zero[i+1] - zero[i];
                for(int j=0; j<one.Count-1; j++)
                {
                    int width = one[j + 1] - one[j];
                    ans = Math.Max(ans, height*width);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
