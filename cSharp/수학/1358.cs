using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1358
    {
        static void Main(string[] args)
        {
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int w = inp[0];
            int h = inp[1];
            int x = inp[2];
            int y = inp[3];
            int p = inp[4];
            int cnt = 0;
            for(int i=0; i<p; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int cx = ints[0];
                int cy = ints[1];
                if(((cx - x) * (cx - x) + (cy - y - h/2) * (cy - y - h/2)) <= (h / 2) * (h / 2) || 
                    (cx >= x && cy >= y && cx <= (x + w) && cy <= (y+h)) ||
                    ((cx - x - w) * (cx - x - w) + (cy - y - h/2) * (cy - y - h/2)) <= (h / 2) * (h / 2))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
