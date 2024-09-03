using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1193
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int index = 1;
            int sum = 2;
            while(index < n)
            {
                index += sum;
                sum++;
            }
            index -= (sum - 1);
            n -= index;
            if(sum%2 == 0)
            {
                Console.WriteLine((sum - n) + "/" + n);
            }
            else
            {

                Console.WriteLine(n + "/" + (sum - n));
            }
        }
    }
}
