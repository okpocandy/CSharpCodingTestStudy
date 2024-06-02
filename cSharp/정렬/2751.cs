using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2751
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] list = new int[N];
            for (int i = 0; i < N; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list[i] = input;
            }
            Array.Sort(list);
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
