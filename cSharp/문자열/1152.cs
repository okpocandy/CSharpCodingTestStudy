using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1152
    {
        public static void Main(string[] args)
        {
            int num;
            string input = Console.ReadLine();
            if (input.Equals(" "))
                num = 0;
            else
            {
                var inputSp = input.Trim().Split(' ');
                num = inputSp.Length;
            }
            Console.WriteLine(num);
        }
    }
}
