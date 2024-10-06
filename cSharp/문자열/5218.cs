using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _5218
    {
        static void Main(
            string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] ss = Console.ReadLine().Split();
                string ans = "Distances:";
                for(int j=0; j < ss[0].Length; j++)
                {
                    int dis = (int)ss[1][j] - (int)ss[0][j];
                    dis = dis >= 0 ? dis : dis + 26;
                    ans += $" {dis}";
                    
                }
                Console.WriteLine(ans);
            }
        }
    }
}
