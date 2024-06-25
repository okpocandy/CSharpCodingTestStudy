using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _9461
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long[] arr = new long[101];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            arr[3] = 1;
            for(int i=4; i<arr.Length; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 3];
            }
            for(int i=0; i<t; i++)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(arr[a]);
            }
        }
    }
}
