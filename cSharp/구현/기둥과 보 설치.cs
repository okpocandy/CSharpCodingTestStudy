using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 기둥과_보_설치
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[][] build_frame = new int[10][] { [0, 0, 0, 1], [2, 0, 0, 1], [4, 0, 0, 1], [0, 1, 1, 1], [1, 1, 1, 1], [2, 1, 1, 1], [3, 1, 1, 1], [2, 0, 0, 0], [1, 1, 1, 0], [2, 2, 0, 1] };
            List<int[]> res = new List<int[]>();
            for(int i=0; i<8; i++)
            {
                int x = build_frame[i][0];
                int y = build_frame[i][1];
                int a = build_frame[i][2];   // 0은 기둥 1은 보
                int b = build_frame[i][3];   // 0은 삭제 1은 설치
                if(b==0)
                {
                    res.Remove([x, y, a]);
                    if(!Possible(res))
                        res.Add([x, y, a]);
                }
                if (b == 1)
                {
                    res.Add([x, y, a]);
                    if (!Possible(res))
                        res.Remove([x, y, a]);
                }
            }
            res.Sort((a, b) =>
            {
                if (a[0] != b[0])
                    return a[0].CompareTo(b[0]);
                else if (a[1] != b[1])
                    return a[1].CompareTo(b[1]);
                else
                    return a[2].CompareTo(b[2]);
            });
            foreach (var arr in res)
            {
                Console.WriteLine($"({arr[0]}, {arr[1]}, {arr[2]})");
            }


        }
        static bool Possible(List<int[]> answer)
        {
            foreach(var i in answer)
            {
                int x = i[0];
                int y = i[1];
                int a = i[2];
                if(a == 0)
                {
                    if (y == 0 || answer.Contains([x, y - 1, 0]) || answer.Contains([x - 1, y, 1]) || answer.Contains([x, y, 1]))
                        continue;
                    else
                        return false;
                }
                else if(a == 1)
                {
                    if (answer.Contains([x, y - 1, 0]) || answer.Contains([x + 1, y - 1, 0]) || (answer.Contains([x - 1, y, 1]) && answer.Contains([x + 1, y, 1])))
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
    }
}

/*

build_frame
{ [1, 0, 0, 1], [1,1,1,1], [2,1,0,1], [2,2,1,1], [5,0,0,1], [5,1,0,1], [4,2,1,1], [3,2,1,1] }

out:
(1, 0, 0)
(1, 1, 1)
(2, 1, 0)
(2, 2, 1)
(3, 2, 1)
(4, 2, 1)
(5, 0, 0)
(5, 1, 0)


build_frame:
{ [0,0,0,1], [2,0,0,1], [4,0,0,1], [0,1,1,1], [1,1,1,1], [2,1,1,1], [3,1,1,1], [2,0,0,0], [1,1,1,0], [2,2,0,1]}

out:
(0, 0, 0)
(0, 1, 1)
(1, 1, 1)
(2, 0, 0)
(2, 0, 0)
(2, 1, 1)
(3, 1, 1)
(4, 0, 0)
*/