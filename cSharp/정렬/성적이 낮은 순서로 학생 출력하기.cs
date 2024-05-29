using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 성적이_낮은_순서로_학생_출력하기
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for(int i=0; i<N; i++)
            {
                string[] input = Console.ReadLine().Split();
                dic.Add(input[0], int.Parse(input[1]));
            }
            Dictionary<string, int> sortDic = dic.OrderBy(item => item.Value).ToDictionary(x =>  x.Key, x => x.Value);
            string[] res = sortDic.Keys.ToArray();
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
