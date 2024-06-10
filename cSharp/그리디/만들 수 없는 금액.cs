using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 만들_수_없는_금액
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] coin = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int target = 1;
            Array.Sort(coin);
            foreach (var i in coin)
            {
                if (target < i)
                    break;
                target += i;

            }
            Console.WriteLine(target);
        }
        
    }
}

/*

3
3 2 1 1 9

*/