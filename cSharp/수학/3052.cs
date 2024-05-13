using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _3052
    {
        static void Main(string[] args)
        {
            int input;
            List<int> ints = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (!ints.Contains(input % 42))
                    ints.Add(input % 42);
            }
            Console.WriteLine(ints.Count);

        }
    }
}
