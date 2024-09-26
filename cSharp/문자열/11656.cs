using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _11656
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            List<string> strings = new List<string>();
            for (int i=0; i<s.Length; i++)
            {
                strings.Add(s[i..]);
            }
            strings.Sort();
            StringBuilder sb = new StringBuilder();
            foreach(var i in strings)
            {
                sb.AppendLine(i);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
