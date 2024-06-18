using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _10816
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] find = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            StringBuilder sb = new StringBuilder();
            foreach (int i in ints)
            {
                if (dic.ContainsKey(i))
                    dic[i] = dic[i] + 1;
                else
                    dic[i] = 1;
            }
            foreach(int i in find)
            {
                if (dic.TryGetValue(i, out int value))
                    sb.Append(value + " ");
                else
                    sb.Append(0 + " ");
            }
            Console.WriteLine(sb.ToString());
        }
        
    }
}
