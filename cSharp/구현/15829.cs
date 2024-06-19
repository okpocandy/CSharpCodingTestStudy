using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _15829
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inp = Console.ReadLine();
            double sum = 0;
            const int m = 1234567891;
            double R = 1;
            for (int i = 0; i < n; i++)
            {
                sum = (sum + (inp[i] - 'a' + 1) * R) % m;
                R = R * 31 % m;
            }
            Console.WriteLine(sum);
        }
    }
}
