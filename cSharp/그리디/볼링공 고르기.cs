using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 볼링공_고르기
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] nums = new int[m + 1];

            foreach (var i in inputs)
                nums[i]++;
            int result = 0;
            for(int i=1; i<=m; i++)
            {
                n -= nums[i];
                result += n * nums[i];
            }
            Console.WriteLine(result);
        }
    }
}


/*

inp :
5 3
1 3 2 3 2

out: 8

inp : 
8 5
1 5 4 3 2 4 5 2

out : 25

*/