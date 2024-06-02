// 시간 초과
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1920
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());
            int[] findArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> list = new List<int>();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<m; i++)
            {
                int a = array.Find(x=> x == findArray[i]);
                array.Remove(a);
                sb.Append((a != 0 ? 1 : 0) + "\n");
            }
            Console.WriteLine(sb);


        }
    }
}
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _1920
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] findArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(array);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < m; i++)
            {
                sb.Append(BS(array, findArray[i], 0, n - 1) + "\n");
            }
            Console.WriteLine(sb);


        }
        static int BS(int[] array, int target, int start, int end)
        {
            if (start > end) { return 0; }
            int mid = (start + end) / 2;
            if (array[mid] == target) { return 1; }
            else if (array[mid] < target) { return BS(array, target, mid + 1, end); }
            else if (array[mid] > target) { return BS(array, target, start, mid - 1); }
            return 0;
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Study
{
    internal class _1920
    {
        static void Main(string[] args)
        {
            // 입력 처리
            int n = int.Parse(Console.ReadLine());
            List<int> array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());
            int[] findArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // 배열 정렬
            array.Sort();
            StringBuilder sb = new StringBuilder();
            // 이진 탐색으로 값 찾기
            foreach (int value in findArray)
            {
                if (BinarySearch(array, value))
                {
                    sb.Append(1 + "\n");
                }
                else
                {
                    sb.Append(0 + "\n");
                }
            }
            Console.WriteLine(sb.ToString());
        }

        static bool BinarySearch(List<int> sortedList, int target)
        {
            int left = 0;
            int right = sortedList.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (sortedList[mid] == target)
                {
                    return true;
                }
                else if (sortedList[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}
*/