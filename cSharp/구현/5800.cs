using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _5800
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            
            for(int i=0; i<k; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int maxDif = 0;
                
                Console.WriteLine($"Class {i+1}");
                int[] sortArr = ints[1..];
                Array.Sort(sortArr, (x,y) => y.CompareTo(x));
                int ma = sortArr.Max();
                int mi = sortArr.Min();

                for (int j = 0; j < ints[0]-1; j++)
                {
                    int dif = Math.Abs(sortArr[j] - sortArr[j + 1]);
                    maxDif = Math.Max(maxDif, dif);
                }
                Console.WriteLine($"Max {ma}, Min {mi}, Largest gap {maxDif}");
            }
        }
    }
}
