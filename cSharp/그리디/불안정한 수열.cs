using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.그리디
{
    internal class 불안정한_수열
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int result = 1;
            int index = 1;
            int pre = 0;
            if (ints[0] % 2 == 1)
                pre = 1;
            if (N == 1)
            {
                result = 1;
            }
            else
            {
                while (index < ints.Length)
                {
                    if (pre == 0 && ints[index] % 2 == 1)
                    {
                        pre = 1;
                        result++;
                    }
                    else if (pre == 1 && ints[index] % 2 == 0)
                    {
                        pre = 0;
                        result++;
                    }
                    index++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
