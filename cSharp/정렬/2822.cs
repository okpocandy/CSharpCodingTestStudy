using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2822
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<8;  i++)
            {
                dic[i+1] = int.Parse(Console.ReadLine());
            }

            var sorted_dic = dic
                .OrderByDescending(x => x.Value)
                .Take(5)
                .OrderBy(x => x.Key)
                .ToArray();

            int ans = sorted_dic.Sum(x=> x.Value);
            Console.WriteLine(ans);
            Console.WriteLine(string.Join(" ", sorted_dic.Select(x=>x.Key)));

        }
    }
}
