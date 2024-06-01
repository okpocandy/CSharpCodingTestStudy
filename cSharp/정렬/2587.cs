using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2587
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> ints = new List<int>();
            for(int i=0; i<5; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                ints.Add(input);
            }
            ints.Sort();
            Console.WriteLine(sum / 5);
            Console.WriteLine(ints[2]);
        }
    }
}
