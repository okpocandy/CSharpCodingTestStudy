using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _7795
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++)
            {
                int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int n = nm[0];
                int m = nm[1];
                int[] af = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int[] bf = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(af);
                Array.Sort(bf);
                int cnt = 0;
                foreach(var a  in af)
                {

                    foreach(var b in bf)
                    {
                        if (a <= b)
                            break;
                        else
                            cnt++;

                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
