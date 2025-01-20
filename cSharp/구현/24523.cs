using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _24523
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] result = new int[n];

            int pre = ar[n-1];
            List<int> ans = new List<int>();
            int tmp = -2;
            ans.Add(tmp+1);
            for(int i=n-2; i>=0; i--)
            {
                if (ar[i] == pre)
                {
                    ans.Add(tmp+1);
                }
                else
                {
                    tmp = i + 1;
                    pre = ar[i];
                    ans.Add(tmp+1);
                }
            }
            ans.Reverse();
            Console.WriteLine(string.Join(" ", ans.ToArray()));
        }
    }
}
