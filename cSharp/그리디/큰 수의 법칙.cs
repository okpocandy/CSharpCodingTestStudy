using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 큰_수의_법칙
    {
        static void Main(string[] args)
        {
            int[] NMK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int ans = 0;
            Array.Sort(nums, (a, b) =>
            {
                if (a > b) return -1;
                else return 1;
            });
            if (nums[0] == nums[1])
            {
                ans = nums[0] * NMK[1];
            }
            else
            {
                ans = NMK[1] / (NMK[2]+1) * nums[1] + (NMK[1] - (NMK[1] / (NMK[2]+1))) * nums[0];
            }
            Console.WriteLine(ans);
        }
    }
}
