using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _20125
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> cookie = new List<string>();
            for(int i=0; i<N; i++)
            {
                cookie.Add(Console.ReadLine());
            }
            int hx = 0;
            int hy = 0;
            for(int i=0; i<N;i++)
            {
                for(int j=0; j<N; j++)
                {
                    if (cookie[i][j] == '*')
                    {
                        hy = i;
                        hx = j;
                        break;
                    }
                }
                if (hx != 0 || hy != 0)
                    break;
            }
            hy++;
            int la = 0;
            int ra = 0;
            int mi = 0;
            int ll = 0;
            int rl = 0;
            for(int i=0; i<hx; i++)
            {
                if (cookie[hy][i] == '*')
                    la++;
            }
            for(int i=hx+1; i<N; i++)
            {
                if (cookie[hy][i] == '*')
                    ra++;
            }
            for(int i=hy+1; i<N; i++)
            {
                if (cookie[i][hx] == '*')
                    mi++;
            }
            for(int i=0; i<N; i++)
            {
                if (cookie[i][hx-1] == '*')
                {
                    ll++;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (cookie[i][hx + 1] == '*')
                {
                    rl++;
                }
            }
            if (la >= 1)
                ll--;
            if (ra >= 1)
                rl--;
            Console.WriteLine((hy + 1) + " " + (hx + 1));
            Console.WriteLine(la + " " + ra + " " + mi + " " + ll + " " + rl);
        }
    }
}
