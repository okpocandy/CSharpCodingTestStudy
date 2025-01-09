using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _31797
    {
        static void Main(string[] args)
        {
            // 입력 처리
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];

            // 손 높이와 참가자 번호 매핑
            Dictionary<int, int> handToPlayer = new Dictionary<int, int>();
            for (int i = 0; i < m; i++)
            {
                int[] hands = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                handToPlayer[hands[0]] = i + 1;
                handToPlayer[hands[1]] = i + 1;
            }

            // 모든 손 높이 리스트
            List<int> handHeights = new List<int>(handToPlayer.Keys);
            handHeights.Sort(); // 손 높이를 오름차순 정렬

            // 손을 n번 반복해서 위로 쌓기
            int index = (n - 1) % handHeights.Count; // 0-based 인덱스
            int finalHeight = handHeights[index];

            // 결과 출력
            Console.WriteLine(handToPlayer[finalHeight]);
        }
    }
}
