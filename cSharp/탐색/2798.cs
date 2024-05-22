using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _2798
    {
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = NM[0];
            int M = NM[1];
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var combinations = GetCombinations(nums, 3);
            int dif = 987654321;
            int ans = 0;
            foreach (var combination in combinations)
            {
                if (Math.Abs(combination.Sum() - M) <= dif && combination.Sum() <= M)
                {
                    ans = combination.Sum();
                    dif = Math.Abs(combination.Sum() - M);
                }

            }
            Console.WriteLine(ans);
        }

        static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length)
        {
            if (length == 0)
                return new List<List<T>> { new List<T>() };

            return list.SelectMany((element, index) =>
                GetCombinations(list.Skip(index + 1), length - 1).Select(c => new List<T> { element }.Concat(c))
            );
        }
    }
}
