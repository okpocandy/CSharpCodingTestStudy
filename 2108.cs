using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2108
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            StringBuilder sb = new StringBuilder(); 
            for(int i=0; i<n; i++)
            {
               
                int inp = int.Parse(Console.ReadLine()) ;
                ints[i] = inp ;
                if (dic.ContainsKey(inp))
                    dic[inp]++;
                else
                    dic[inp] = 1;
            }
            List<KeyValuePair<int, int>> sortedList = dic.ToList();
            sortedList.Sort((x,y) =>
            {
                int result = y.Value.CompareTo(x.Value);
                if(result == 0)
                    result = -y.Key.CompareTo(x.Key);
                return result;
            });
            int c = 0;
            if (sortedList.Count > 1)
            {
                if (sortedList[0].Value != sortedList[1].Value)
                {
                    c = sortedList[0].Key;
                }
                else
                    c = sortedList[1].Key;
            }
            else
                c = sortedList[0].Key;

            double a = Math.Round(((double)ints.Sum() / (double)n));
            if (a == -0)
                a = 0;
            
            Array.Sort(ints);
            int b = ints[n / 2];
            int d = ints[^1] - ints[0];
            sb.Append(a + "\n");
            sb.Append(b + "\n");
            sb.Append(c + "\n");
            sb.Append(d + "\n");
            Console.WriteLine(sb.ToString());
        }
    }
}
