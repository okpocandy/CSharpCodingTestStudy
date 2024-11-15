using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class _1233
    {
        static void Main(string[] args)
        {
            int[] ss = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int s1 = ss[0];
            int s2 = ss[1];
            int s3 = ss[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=1; i<=s1; i++)
            {
                for(int j=1; j<=s2; j++)
                {
                    for(int k=1; k<=s3; k++)
                    {
                        int tmp = i + j + k;
                        if (dic.ContainsKey(tmp))
                            dic[tmp]++;
                        else
                            dic[tmp] = 1;
                    }
                }
            }
            var sortedDic = dic
                .Where(x => x.Value == dic.Values.Max())
                .OrderBy(x => x.Key)
                .First();

            Console.WriteLine(sortedDic.Key);
        }
    }
}
