using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _9506
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == -1)
                    break;
                int sum = 0;
                StringBuilder sb = new StringBuilder();
                List<int> list = new List<int>();
                sb.Append($"{n} =");
                for (int i = 1; i < n; i++)
                {
                    if(n%i == 0)
                    {
                        list.Add(i);
                        sum += i;
                    }
                }
                if (sum == n)
                {
                    foreach(int i in list)
                        sb.Append($" {i} +");
                    Console.WriteLine(sb.ToString()[..^2]);
                }
                else
                    Console.WriteLine($"{n} is NOT perfect.");

            }
        }
    }
}
