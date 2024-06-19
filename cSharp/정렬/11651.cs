using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _11651
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int x, int y)> ls = new List<(int x, int y)>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int x = xy[0];
                int y = xy[1];
                ls.Add((x, y));
            }
            ls.Sort((a, b) =>
            {
                if (a.y != b.y)
                    return a.y.CompareTo(b.y);
                else
                    return a.x.CompareTo(b.x);
            });
            foreach (var i in ls)
                sb.Append(i.x + " " + i.y + "\n");
            Console.WriteLine(sb.ToString());
        }
    }
}
