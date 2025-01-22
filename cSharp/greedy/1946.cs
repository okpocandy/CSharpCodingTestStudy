using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        for (int t = 0; t < testCases; t++)
        {
            int n = int.Parse(Console.ReadLine());
            var applicants = new List<(int document, int interview)>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                int document = int.Parse(input[0]);
                int interview = int.Parse(input[1]);
                applicants.Add((document, interview));
            }

            applicants.Sort((a, b) => a.document.CompareTo(b.document));

            int maxCount = 0;
            int bestInterviewRank = int.MaxValue;

            foreach (var applicant in applicants)
            {
                if (applicant.interview < bestInterviewRank)
                {
                    maxCount++;
                    bestInterviewRank = applicant.interview;
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
