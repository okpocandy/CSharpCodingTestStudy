using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Study.cSharp.문자열
{
    class _8892
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool foundPalindrome = false;
                List<string> words = new List<string>();

                for (int j = 0; j < n; j++)
                    words.Add(Console.ReadLine());

                for (int k = 0; k < n && !foundPalindrome; k++)
                {
                    for (int m = 0; m < n; m++)
                    {
                        if (k == m) continue;  // 같은 단어끼리 합치지 않도록

                        string combined = words[k] + words[m];
                        string reversed = new string(combined.Reverse().ToArray());

                        if (combined == reversed)
                        {
                            Console.WriteLine(combined);
                            foundPalindrome = true;
                            break;
                        }
                    }
                }

                if (!foundPalindrome)
                    Console.WriteLine(0);
            }
        }
    }
}
