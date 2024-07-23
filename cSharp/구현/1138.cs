using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1138
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] ans = new int[n];
            /*
            for(int i=0; i<n; i++)
            {
                int a = ints[i];
                while (ans[a] != 0)
                    a++;
                ans[a] = i + 1;
            }
            */
            for (int i = 0; i < n; i++)
            {
                int cnt = 0;
                int a = 0;
                for (int j = 0; j < n; j++)
                {
                    if (ans[j] == 0)
                    {
                        cnt++;
                        if (cnt == ints[i] + 1)
                        {
                            a = j;
                            break;
                        }
                    }
                }
                ans[a] = i + 1;
            }
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
