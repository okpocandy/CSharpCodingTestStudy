using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _10798
    {
        static void Main(string[] args)
        {
            List<char[]> ls = new List<char[]>();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<5; i++)
            {
                ls.Add(Console.ReadLine().ToArray());
            }
            for(int i=0; i<15; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if (ls[j].Length > i)
                        sb.Append(ls[j][i]);
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
