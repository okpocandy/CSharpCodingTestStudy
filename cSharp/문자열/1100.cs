using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1100
    {
        static void Main(string[] args)
        {
            List<char[]> graph = new List<char[]>();
            for (int i = 0; i < 8; i++)
            {
                graph.Add(Console.ReadLine().ToArray());
            }
            int cnt = 0;
            for (int i = 0; i < 8; i++)
            {
                for(int j=0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if(j %2 == 0)
                        {
                            if (graph[i][j] == 'F')
                                cnt++;
                        }
                    }
                    else
                    {
                        if(j %2 == 1)
                        {
                            if (graph[i][j] == 'F')
                                cnt++;
                        }
                    }
                }
                
            }
            Console.WriteLine(cnt);
        }
        
        
    }
}
