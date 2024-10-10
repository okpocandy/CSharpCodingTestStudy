using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _11478
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            for(int i=1; i<=s.Length; i++)
            {
                for(int j=0; j<=s.Length-i; j++)
                {
                    set.Add(s[j..(j+i)]);
                }
            }
            Console.WriteLine(set.Count);
        }
    }
}
