using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace C_Sharp_Study.정렬
{
    internal class _1181
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] strings = new string[count];
            for (int i = 0; i < count; i++)
            {
                strings[i] = Console.ReadLine();
            }
            string[] answer = strings.Distinct().ToArray();
            Array.Sort(answer, (a, b) =>
            {
                if (a.Length < b.Length)
                    return -1;
                else if (a.Length > b.Length)
                    return 1;
                else
                    return string.Compare(a, b);
            });

            for (int i = 0; i < answer.Length; ++i)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
