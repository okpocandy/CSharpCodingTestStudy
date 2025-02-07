using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 볼링공_고르기
    {
        static void Main(string[] args)
        {
            static void Main(String[] args)
            {
                int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int n = nm[0];
                int m = nm[1];
                int[] balls =Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] arr = new int[11];
                foreach(var ball in balls)
                {
                    arr[ball]++;
                }
                int result = 0;
                for(int i=1; i<m+1; m++)
                {
                    n -= arr[i];
                    result += arr[i] * n;
                }

                Console.WriteLine(result);
            }
        }
    }
}

/*
 
입력:
5 3
1 3 2 3 2

출력
8

입력:
8 5

출력:
1 5 4 3 2 4 5 2
 
 */