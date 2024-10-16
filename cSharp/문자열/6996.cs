using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _6996
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] ab = Console.ReadLine().Split();
                string a = ab[0];
                string b= ab[1];
                char[] ac = a.ToCharArray();
                char[] bc = b.ToCharArray();
                Array.Sort(ac);
                Array.Sort(bc);
                bool ans = true;
                if(ac.Length == bc.Length)
                {
                    int c = Math.Min(ac.Length, bc.Length);
                    for (int j = 0; j < c; j++)
                    {
                        if (ac[j] == bc[j])
                            continue;
                        ans = false;
                    }
                    if (ans)
                        Console.WriteLine($"{a} & {b} are anagrams.");
                    else
                        Console.WriteLine($"{a} & {b} are NOT anagrams.");
                }
                else
                    Console.WriteLine($"{a} & {b} are NOT anagrams.");

            }
        }
    }
}
