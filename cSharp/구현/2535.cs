using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2535
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> score = new List<int[]>();

            // 데이터 입력 및 통합 리스트에 추가
            for (int i = 0; i < n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                score.Add(new int[] { ints[0], ints[1], ints[2] });
            }

            // 전체 데이터를 ints[2] 값에 따라 내림차순으로 정렬
            score.Sort((a, b) => b[2].CompareTo(a[2]));

            int cnt = 1;
            StringBuilder sb = new StringBuilder();
            sb.Append(score[0][0] + " " + score[0][1] + "\n");
            int ban = score[0][0];
            sb.Append(score[1][0] + " " + score[1][1] + "\n");
            if (ban == score[1][0])
            {
                cnt++;
            }
            if (cnt == 1)
            {
                sb.Append(score[2][0] + " " + score[2][1] + "\n");
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (score[i][0] != ban)
                    {
                        sb.Append(score[i][0] + " " + score[i][1] + "\n");
                        break;
                    }
                }

            }
            Console.WriteLine(sb.ToString());

        }
    }
}
