using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Study.cSharp.정렬
{
    internal class _10814
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, string)> ls = new List<(int, string)> ();
            for(int i=0; i<n; i++)
            {
                string[] inp = Console.ReadLine().Split();
                ls.Add((int.Parse(inp[0]), inp[1]));
            }
            var sortList = ls.OrderBy(x => x.Item1).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var i in sortList)
            {
                sb.Append(i.Item1 + " " + i.Item2 + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}
