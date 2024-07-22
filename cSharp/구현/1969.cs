using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1969
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = ints[0];
            int length = ints[1];
            List<string> strings = new List<string>();
            char[] result = new char[length];
            int cnt = 0;
            for (int i=0; i<n; i++)
            {
                strings.Add(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                Dictionary<char, int> freq = new Dictionary<char, int>();
                foreach (string str in strings)
                {
                    if (freq.ContainsKey(str[i]))
                    {
                        freq[str[i]]++;
                    }
                    else
                    {
                        freq[str[i]] = 1;
                    }
                }

                int maxCount = -1;
                char mostFrequentChar = 'Z';
                
                foreach (var item in freq)
                {
                    if (item.Value > maxCount || (item.Value == maxCount && item.Key < mostFrequentChar))
                    {
                        maxCount = item.Value;
                        mostFrequentChar = item.Key;
                    }
                }

                result[i] = mostFrequentChar;
            }

            string resultString = new string(result);
            for(int i=0; i<n;i++)
            {
                for(int j=0; j<length; j++)
                {
                    if (resultString[j] != strings[i][j])
                        cnt++;
                }
            }
            Console.WriteLine(resultString);
            Console.WriteLine(cnt);
        }
    }
}
