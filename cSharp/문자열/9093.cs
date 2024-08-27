using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _9093
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                string[] tmp = new string[s.Length];
                for(int j=0; j<s.Length; j++)
                {
                    tmp[j] = new string ( s[j].Reverse().ToArray() );
                }
                Console.WriteLine(string.Join(" ", tmp));
            }
        }
    }
}
