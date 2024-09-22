using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _9536
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                string[] cries = Console.ReadLine().Split();
                while(true)
                {
                    string[] tmp = Console.ReadLine().Split();
                    if (tmp[^1].Equals("say?"))
                        break;
                    else
                    {
                        cries = cries.Where(a => a.Equals(tmp[^1]) == false).ToArray();
                    }
                }
                sb.Append(string.Join(" ", cries));
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }

            
        }
    }
}
