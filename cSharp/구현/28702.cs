using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _28702
    {
        static void Main(string[] args)
        {
            int a = 0;
            int intInp = 0;
            for (int i = 0; i < 3; i++)
            {
                string inp = Console.ReadLine();
                if (int.TryParse(inp, out intInp))
                {
                    a = i;
                    break;
                }
            }
            a = intInp + (3 - a);
            if (a % 5 == 0 && a % 3 == 0) { Console.WriteLine("FizzBuzz"); }
            else if (a % 5 == 0 && a % 3 != 0) { Console.WriteLine("Buzz"); }
            else if (a % 5 != 0 && a % 3 == 0) { Console.WriteLine("Fizz"); }
            else { Console.WriteLine(a); }

        }
    }
}
