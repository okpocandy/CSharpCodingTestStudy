using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class 이진_탐색_예제
    {
        static void Main(string[] args)
        {
            int[] nt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nt[0];
            int t = nt[1];
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int result = BS(arr, t, 0, n - 1);
            if (result == 0)
                Console.WriteLine("원소가 존재하지 않습니다.");
            else
                Console.WriteLine(result + 1);
        }

        static int BS(int[] arr, int target, int st, int ed)
        {
            if (st > ed)
                return 0;
            int mid = (st + ed) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] > target)
                return BS(arr, target, st, mid - 1);
            else
                return BS(arr, target, mid + 1, ed);

        }
    }
}

/*
 
입력:
10 7
1 3 5 7 9 11 13 15 17 19

출력:
4

입력:
10 7
1 3 5 6 9 11 13 15 17 19

출력:
원소가 존재하지 않습니다.
 
 
 */