using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1913
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int m = n;
            int k = int.Parse(Console.ReadLine());
            int[,] ints = new int[n, n];
            int tmp = n * n;
            int a = 0;
            (int, int) ans = (0,0);
            while (true)
            {
                
                for (int i = a; i < n; i++)
                {
                    ints[i, a] = tmp--;
                        
                }
                for (int i = a + 1; i < n; i++)
                {
                    ints[n-1, i] = tmp--;
                }
                for (int i = n - 2; i >= a; i--)
                {
                    ints[i, n-1] = tmp--;
                }
                for (int i = n - 2; i > a; i--)
                {
                    ints[a, i] = tmp--;
                }
                n -= 1;
                a++;
                if (n == 1)
                    break;
            }
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<m; i++)
            {
                for(int j=0; j<m; j++)
                {
                    sb.Append(ints[i, j] + " ");
                    if (ints[i, j] == k)
                        ans = (i + 1, j + 1);
                }
                if(i == m-1)
                    continue;   
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine(ans.Item1 + " " + ans.Item2);
        }
    }
}
