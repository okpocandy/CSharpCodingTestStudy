using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class 순차_탐색_예제
    {
        static void Main(string[] args)
        {
            Console.WriteLine("생성할 원소 개수를 입력한 다음 한 칸 띄고 찾을 문자열을 입력하세요.");
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            string target = input[1];

            Console.WriteLine("앞서 적은 원소 개수만큼 문자열을 입력하세요. 구분은 띄어쓰기 한 칸으로 합니다.");
            string[] array = Console.ReadLine().Split();

            Console.WriteLine(sequential_search(n, target, array));
        }
        static int sequential_search(int n, string target, string[] array)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i].Equals(target))
                    return i + 1;
            }
            return 0;
        }
    }
}
