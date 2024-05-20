using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1259
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "0")
                    break;
                string rev_input = new string(input.Reverse().ToArray());

                if (input.Equals(rev_input))
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}
