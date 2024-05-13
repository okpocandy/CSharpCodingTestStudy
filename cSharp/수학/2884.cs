using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2884
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int H = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            M -= 45;
            if (M < 0)
            {
                M = 60 + M;
                H -= 1;
                if(H < 0)
                {
                    H = 24 + H;
                }
            }
            Console.WriteLine($"{H} {M}");
                
        }
    }
}
