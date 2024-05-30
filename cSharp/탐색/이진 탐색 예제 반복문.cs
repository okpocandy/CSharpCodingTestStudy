using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class 이진_탐색_예제_반복문
    {
        static void Main(string[] args)
        {
            int[] ntarget = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = ntarget[0];
            int target = ntarget[1];

            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int result = BinarySearch(array, target, 0, n-1);
            if(result == -1) { Console.WriteLine("원소가 존재하지 않습니다."); }
            else { Console.WriteLine(result+1);}
        }

        static int BinarySearch(int[] array, int target, int start, int end)
        {
            while (start <= end)
            {
                int mid = (start + end)/2;
                if (array[mid] == target)
                    return mid;
                else if (array[mid] > target)
                    end = mid - 1;
                else { start = mid + 1; }
            }
            return -1;
        }
    }
}
