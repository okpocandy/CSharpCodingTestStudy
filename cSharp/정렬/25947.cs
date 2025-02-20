using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _25947
    {
        static void Main(string[] args)
        {
            int[] nba = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nba[0]; 
            int b = nba[1];
            int a = nba[2];
            int[] gifts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(gifts);
            long[] sum = new long[n];
            sum[0] = gifts[0];
            int ans = 0;
            for(int i=1; i<gifts.Length; i++)
            {
                sum[i] = gifts[i] + sum[i-1];
            }
            for(int i=0; i<n; i++)
            {
                long tmp = 0;
                int index = (i - a);
                if(index < 0)
                {
                    tmp += sum[i];
                    tmp /= 2;
                }
                else
                {
                    tmp += sum[i] - (sum[i] - sum[index]) / 2;
                }
                if(tmp <= b)
                {
                    ans = i+1;
                }
                    
            }
            Console.WriteLine(ans);
        }
    }
}
