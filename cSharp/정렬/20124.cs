using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _20124
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();    
            for(int i=0; i<n; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                string name = inputs[0];
                int score = int.Parse(inputs[1]);
                dic[name] = score;
            }

            List<int> list = dic.Values.ToList();
            list.Sort();

            var a = dic
                .Where(x => x.Value == list[list.Count-1])
                .Select(x => x.Key)
                .ToList();

            a.Sort();
            Console.WriteLine(a[0]);
        }
    }
}
