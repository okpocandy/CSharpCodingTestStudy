using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class _9455
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                List<int[]> ls = new List<int[]>();
                int ans = 0;
                for (int j = 0; j < ints[0]; j++)
                {
                    ls.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
                }
                for(int k=0; k < ints[1];  k++)
                {
                    int cnt = 0;
                    for (int l=ints[0]-1; l >= 0;  l--)
                    {
                        
                        if (ls[l][k] == 1)
                        {
                            ans += ints[0] - 1 - l - cnt;
                            cnt++;
                        }
                    }

                }
                Console.WriteLine(ans);
            }
            
            
            
        }
    }
}
