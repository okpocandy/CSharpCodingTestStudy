using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int result = 0;


        for (char outer = 'A'; outer <= 'Z'; outer++)
        {
            int firstIndex = input.IndexOf(outer);
            int secondIndex = input.LastIndexOf(outer);

            if (firstIndex == -1 || secondIndex == -1) continue;

            var betweenCounts = new Dictionary<char, int>();
            for (int i = firstIndex + 1; i < secondIndex; i++)
            {
                char current = input[i];
                if (!betweenCounts.ContainsKey(current))
                    betweenCounts[current] = 0;
                betweenCounts[current]++;
            }

            foreach (var count in betweenCounts.Values)
            {
                if (count == 1)
                    result++;
            }
        }

        Console.WriteLine(result / 2);
    }
}
