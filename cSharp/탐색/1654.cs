using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _1654
    {
        static int k;
        static int n;
        static List<int> res = new List<int>();
        static void Main(string[] args)
        {
            int[] kn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            k = kn[0];
            n = kn[1];
            int[] nums = new int[k];
            for(int i = 0; i<k; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                nums[i] = inp;
            }
            long min_nums = nums.Max();
            long ans = 0;
            ans = BS(nums, 1, min_nums);
            Console.WriteLine(ans);
        }
        
        static long BS(int[] nums, long start, long end)
        {
            while (start<=end)
            {
                long mid = (start+end)/2;

                long sum = 0;
                for(int i=0; i<k;i++)
                {
                    sum += nums[i] / mid;
                }
                if (sum >= n)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return end;
        }
        


    }
}
