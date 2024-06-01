using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _9076
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                int[] score = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(score);
                if ((score[3] - score[1]) >= 4)
                    Console.WriteLine("KIN");
                else
                    Console.WriteLine(score[1] + score[2] + score[3]);
            }
        }
    }
}
