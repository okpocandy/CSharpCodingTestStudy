using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _5533
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> ints = new List<int[]>();
            for(int i=0; i<n; i++)
            {
                ints.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            }
            int[] sum = new int[n];
            for(int i=0; i<3; i++)
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();
                foreach (var j in ints)
                {
                    if (dic.ContainsKey(j[i]))
                        dic[j[i]]++;
                    else
                        dic[j[i]] = 1;
                }
                for(int j=0; j<n; j++)
                {
                    if (dic[ints[j][i]] == 1)
                        sum[j] += ints[j][i];
                }
            }
            foreach(var i in sum)
                Console.WriteLine(i);
            
            
        }
    }
}
