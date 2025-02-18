using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class _1339
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            Dictionary<char, int> nums = new Dictionary<char, int>();
            nums['A'] = 10; nums['B'] = 10; nums['C'] = 10; nums['D'] = 10;
            nums['E'] = 10; nums['F'] = 10; nums['G'] = 10; nums['H'] = 10;
            nums['I'] = 10; nums['J'] = 10;
            PriorityQueue<char, int> pq = new PriorityQueue<char, int>();
            for (int i=0; i<n; i++)
            {
                string s= Console.ReadLine();
                words[i] = s;
                for(int j=0; j<s.Length; j++)
                {
                    pq.Enqueue(s[j], -(s.Length - j));
                }
            }
            int maxnum = 9;
            while(maxnum > -1 && pq.Count > 0)
            {
                var ch = pq.Dequeue();
                if (nums[ch] == 10)
                {
                    nums[ch] = maxnum;
                    maxnum--;
                }
            }
            int ans = 0;
            foreach(var s in words)
            {
                double tmp = 0;
                for(int i=s.Length-1; i>=0; i--)
                {
                    tmp += nums[s[(s.Length -1) -i]] * Math.Pow(10, i);
                }
                ans += (int)tmp;
            }
            Console.WriteLine(ans);
        }
    }
}
