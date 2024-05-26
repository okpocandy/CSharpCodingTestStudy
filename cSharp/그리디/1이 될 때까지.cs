using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1이_될_때까지
    {
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = NM[0];
            int M = NM[1];
            int count = 0;

            while (N != 1)
            {
                if(N >= M)
                {
                    if (N % M == 0)
                    {
                        N /= M;
                        count++;
                    }
                    else
                    {
                        count += N % M;
                        N -= N % M;   
                    }
                }
                else
                {
                    count += N - 1;
                    N -= (N - 1);
                }
                
                
                
            }
            Console.WriteLine(count);
        }
    }
}
