using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2564
    {
        static int width;
        static int height;
        static void Main(string[] args)
        {
            int[] wh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            width = wh[0];
            height = wh[1];
            int n = int.Parse(Console.ReadLine());
            int end = 2*(width + height);
            int ans = 0;
            List<int> targets = new List<int>();
            for(int i=0; i<n; i++)
            {
                int[] dirdis = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                targets.Add(Change1D(dirdis[0], dirdis[1]));
            }
            int[] mes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int me = Change1D(mes[0], mes[1]);
            foreach(int target in targets)
            {
                int dif = Math.Abs(me - target);
                ans += Math.Min(dif, (end - dif));
            }
            Console.WriteLine(ans);
        }
        static int Change1D(int dir, int dis)
        {
            int tmp = 0;
            switch(dir)
            {
                case 1:
                    tmp += dis;
                    break;
                case 2:
                    tmp += height + width + (width - dis);
                    break;
                case 3:
                    tmp += height + width * 2 + (height - dis);
                    break;
                default:
                    tmp += width + dis;
                    break;
            }
            return tmp;
        }
    }
}
