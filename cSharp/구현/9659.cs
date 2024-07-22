using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _9659
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("CY");
            else
                Console.WriteLine("SK");
        }
    }
}
