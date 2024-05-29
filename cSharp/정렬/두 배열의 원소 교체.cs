using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 두_배열의_원소_교체
    {
        static void Main(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = NK[0];
            int K = NK[1];
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(A);
            Array.Sort(B);

            int indexA = 0;
            int indexB = B.Length - 1;
            
            for(int i=0; i< K; i++)
            {
                if (A[i] < B[N - i - 1])
                    (A[i], B[N - i - 1]) = (B[N - i - 1], A[i]);
                else
                    break;
            }
            Console.WriteLine(A.Sum());
        }
        
    }
}
