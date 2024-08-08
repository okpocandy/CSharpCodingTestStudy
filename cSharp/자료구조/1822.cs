using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조
{
    internal class _1822
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ab[0];
            int b = ab[1];
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] ba = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // A 집합과 B 집합을 HashSet으로 생성
            HashSet<int> ah = new HashSet<int>(aa);
            HashSet<int> bh = new HashSet<int>(ba);

            // A 집합에서 B 집합을 제외한 차집합을 계산
            ah.ExceptWith(bh);

            // 차집합이 비어 있는지 확인
            if (ah.Count != 0)
            {
                // 차집합을 배열로 변환 후 정렬
                int[] result = ah.ToArray();
                Array.Sort(result);

                // 차집합의 길이와 결과 출력
                Console.WriteLine(result.Length);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                // 차집합이 비어 있을 경우 0을 출력
                Console.WriteLine(0);
            }
        }
    }
}
