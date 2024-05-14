using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _10951
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;
                Console.WriteLine(input[0] + input[2] - 96);
            }
        }
    }
}
