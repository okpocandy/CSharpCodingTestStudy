using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToList();

        if (N < 3)
        {
            Console.WriteLine(N);
            return;
        }

        A.Sort();
        int maxLength = 2;

        for (int i = 0; i < N - 2; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                int count = 2;
                for (int k = j + 1; k < N; k++)
                {
                    if (A[i] + A[j] > A[k])
                        count++;
                    else
                        break;
                }
                maxLength = Math.Max(maxLength, count);
            }
        }

        Console.WriteLine(maxLength);
    }
}
