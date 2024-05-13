using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _8958
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            string input;
            for (int i = 0; i < testCase; i++)
            {
                int score = 1;
                int sum = 0;
                char pre = 'X';
                input = Console.ReadLine();
                foreach (var c in input)
                {
                    if (c == 'O')
                    {
                        if (pre == 'O')
                        {
                            score++;
                        }
                        pre = 'O';
                        sum += score;
                    }
                    else
                    {
                        pre = 'X';
                        score = 1;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
