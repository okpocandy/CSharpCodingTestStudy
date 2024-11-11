using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _9342
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^[ABCDEF]?A+F+C+[ABCDEF]?$";
            for (int i=0; i<n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                    Console.WriteLine("Infected!");
                else
                    Console.WriteLine("Good");

            }
        }
    }
}
