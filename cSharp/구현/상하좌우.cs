using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 상하좌우
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split();
            int x = 1;
            int y = 1;

            foreach (string input in inputs)
            {
                switch (input)
                {
                    case "L":
                        if (x > 1)
                            x -= 1;
                        break;
                    case "R":
                        if (x < N)
                            x += 1;
                        break;
                    case "U":
                        if (y > 1)
                            y -= 1;
                        break;
                    case "D":
                        if (y < N)
                            y += 1;
                        break;

                }
                Console.WriteLine($"{y} {x}");
            }
        }
    }
}
