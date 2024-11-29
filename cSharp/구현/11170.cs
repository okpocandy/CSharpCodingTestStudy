using System;

namespace C_Sharp_Study.cSharp.구현
{
    internal class CountZero
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                int count = 0;

                // N부터 M까지 모든 숫자 확인
                for (int num = n; num <= m; num++)
                {
                    string numStr = num.ToString();
                    foreach (char c in numStr)
                    {
                        if (c == '0')
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
