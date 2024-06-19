using System;
using System.IO;
using System.Text;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _10989
    {
        static void Main(string[] args)
        {
            int[] count = new int[10001]; // 각 수의 개수를 저장할 배열
            StringBuilder sb = new StringBuilder();


            int n = int.Parse(Console.ReadLine());

            // 입력된 수의 개수를 카운트
            for (int i = 0; i < n; i++)
            {
                count[int.Parse(Console.ReadLine())]++;
            }

            // 카운트 배열을 기반으로 정렬된 결과 출력
            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        sb.Append(count[i]);
                    }
                }
                if (i % 100 == 0)
                {
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                }

            }
        }
    }
}
