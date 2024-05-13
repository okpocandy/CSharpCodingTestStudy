/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();

            int ans = int.Parse(A) * int.Parse(B) * int.Parse(C);
            string s_ans = ans.ToString();
            int[] ints = new int[10];  
            for(int i=0; i<s_ans.Length; i++)
            {
                ints[(int)s_ans[i] - 48] += 1;
            }
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/