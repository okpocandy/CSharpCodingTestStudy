using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 숫자카드게임
    {
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int min = 987654321;
            int max = 0;
            for(int i =0; i < NM[0]; i++)
            {
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int min_nums = nums.Min();
                max = Math.Max(max, min_nums);
            }
            Console.WriteLine(max);
        }
    }
}
