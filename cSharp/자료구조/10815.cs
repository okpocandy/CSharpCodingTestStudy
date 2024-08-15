using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조
{
    internal class _10815
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            int[] ls = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach(var i in ls)
                numbers.Add(i);
            int m = int.Parse(Console.ReadLine());
            int[] fd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] ans = new int[m];
            for(int i = 0; i < m; i++)
            {
                if (numbers.Contains(fd[i]))
                    ans[i] = 1;
            }
            Console.WriteLine(string.Join (" ", ans));
        }
    }
}
