using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1008
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            double ans = double.Parse(inputs[0]) / double.Parse(inputs[1]);
            Console.WriteLine(ans);
        }
    }
}
