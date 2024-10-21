using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _11383
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
                strings[i] = Console.ReadLine();
            bool ans = true;
            for (int i=0; i<n; i++)
            {
                string tmp = Console.ReadLine();
                for(int j=0; j<m; j++)
                {
                    if(strings[i][j] == tmp[2*j] && strings[i][j] == tmp[2*j+1])
                        continue;
                    else
                    {
                        ans = false;
                        break;
                    }
                }
            }
            if (ans)
                Console.WriteLine("Eyfa");
            else
                Console.WriteLine("Not Eyfa");
        }
    }
}
