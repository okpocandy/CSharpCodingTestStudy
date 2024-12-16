using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2910
    {
        static void Main(string[] args)
            {
                int[] nc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int n = nc[0];
                int c = nc[1];
                Dictionary<int, int> dic = new Dictionary<int, int>();
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                foreach(int i in ints)
                {
                    if(dic.ContainsKey(i))
                        dic[i]++;
                    else
                        dic[i] = 1;
                }
                var sorted_dic = dic
                .OrderByDescending(x => x.Value);
                foreach(var i in sorted_dic)
                {
                    for(int j=0; j<i.Value; j++)
                    {
                        Console.Write(i.Key + " ");
                    }
                }
            }
    }
}
