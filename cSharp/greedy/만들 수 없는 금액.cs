using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 만들_수_없는_금액
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] coins = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(coins);
            int target = 1;
            foreach(int coin in coins)
            {
                if (target < coin)
                    break;
                target += coin;
            }
            Console.WriteLine(target);
        }
    }
}

/*
 
입력:
5
3 2 1 1 9

 */