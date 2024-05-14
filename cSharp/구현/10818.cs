using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _10818
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int max_ans = ints.Max();
            int min_ans = ints.Min();
            Console.WriteLine($"{min_ans} {max_ans}");
        }
    }
}
