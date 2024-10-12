using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _9933
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ls = new List<string>();   
            for(int i=0; i<n; i++)
            {
                ls.Add(Console.ReadLine());
            }
            foreach(var s in ls)
            {
                string tmp = new string(s.Reverse().ToArray());
                if (ls.Contains(tmp))
                {
                    Console.WriteLine(tmp.Length + " " + tmp[tmp.Length / 2]);
                    break;
                }
            }
        }
    }
}
