using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _18310_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] houses = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(int house in houses)
            {
                int tmp = 0;
                foreach(int difhou  in houses)
                {
                    tmp += Math.Abs(house - difhou);
                }
                dic[house] = tmp;
            }
            var sortedDic = dic.OrderBy(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine(sortedDic.First().Key);
        }
    }
}
