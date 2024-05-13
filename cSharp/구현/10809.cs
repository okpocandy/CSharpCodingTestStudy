using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _10809
    {
        static void Main(string[] args)
        {
            int[] chars = new int[26] {-1,-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (chars[input[i] - 97] == -1)
                    chars[input[i] - 97] = i;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + " ");
            }
        }
    }
}
