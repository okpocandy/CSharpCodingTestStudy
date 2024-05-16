using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _9498
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case >= 90:
                    Console.WriteLine("A");
                    break;
                case >= 80:
                    Console.WriteLine("B");
                    break;
                case >= 70:
                    Console.WriteLine("C");
                    break;
                case >= 60:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
}
