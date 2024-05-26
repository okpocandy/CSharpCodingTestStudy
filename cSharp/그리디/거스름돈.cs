using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 거스름돈
    {
        static void Main(string[] args)
        {
            int n = 1260;
            int count = 0;
            int[] coins = new int[] { 500, 100, 50, 10};

            foreach (int coin in coins)
            {
                count += n / coin;
                n = n % coin;
            }
            Console.WriteLine(count);
        }
    }
}
