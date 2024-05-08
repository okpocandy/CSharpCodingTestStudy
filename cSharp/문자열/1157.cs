using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1157
    {

        static void Main(string[] args)
        {

            int max = 0;
            int maxIndex = 0;
            bool a = false;
            string input = Console.ReadLine().ToUpper();
            int[] alpha = new int[26];
            for (int i = 0; i < input.Length; i++)
            {
                alpha[input[i] - 65]++;
            }
            for (int j = 0; j < alpha.Length; j++)
            {
                if (alpha[j] > max)
                {
                    max = alpha[j];
                    maxIndex = j;
                    a = false;
                }
                else if (alpha[j] == max)
                {
                    a = true;
                }
            }

            if (a)
                Console.WriteLine("?");
            else
                Console.WriteLine((char)(maxIndex + 65));

        }

    }
}
