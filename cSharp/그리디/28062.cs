using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.그리디
{
    internal class _28062
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] candies = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(candies, (a, b) =>
            {
                if (a > b) return -1;
                else return 1;
            });

            int result = 0;
            int odd = 0;
            foreach(int candy in candies)
            {
                if (candy % 2 == 0)
                {
                    result += candy;
                }
                else
                {
                    if(odd != 0)
                    {
                        result += odd;
                        result += candy;
                        odd = 0;
                    }
                    else
                    {
                        odd = candy;
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
