using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _11720
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += nums[i] - 48;
            }
            Console.WriteLine(sum);
        }
    }
}
