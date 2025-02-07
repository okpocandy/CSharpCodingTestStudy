using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 모험가_길드
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr, (a,b) => b.CompareTo(a));
            int index = 0;
            int ans = 0;
            while(true)
            {
                int a = arr[index];
                index += a;
                ans++;
                if (index > arr.Length - 1)
                    break;
            }
            Console.WriteLine(ans);
         }
        
    }
}

/*
 
입력:
5
2 3 1 2 2

출력:
2

 */