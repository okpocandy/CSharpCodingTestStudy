using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 위에서_아래로
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> ints = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int input = int.Parse((Console.ReadLine()));
                ints.Add(input);
            }


            ints.Sort(new Comparison<int>((a, b) => b.CompareTo(a)));
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
