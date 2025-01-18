using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int clockNumber = GetClockNumber(numbers);

        HashSet<int> allClockNumbers = new HashSet<int>();
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        int[] card = { i, j, k, l };
                        allClockNumbers.Add(GetClockNumber(card));
                    }
                }
            }
        }

        List<int> sortedClockNumbers = allClockNumbers.ToList();
        sortedClockNumbers.Sort();

        int rank = sortedClockNumbers.IndexOf(clockNumber) + 1;

        Console.WriteLine(rank);
    }

    static int GetClockNumber(int[] numbers)
    {
        int minNumber = int.MaxValue;

        for (int i = 0; i < 4; i++)
        {
            int rotatedNumber = 0;
            for (int j = 0; j < 4; j++)
            {
                rotatedNumber = rotatedNumber * 10 + numbers[(i + j) % 4];
            }
            minNumber = Math.Min(minNumber, rotatedNumber);
        }

        return minNumber;
    }
}
