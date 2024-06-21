using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1297
    {
        static void Main(string[] args)
        {
            int[] dhw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int d = dhw[0];
            int h = dhw[1];
            int w = dhw[2];

            double sD = d * d; ;
            double sH = sD * (h * h) / (h * h + w * w);
            double sW = sD * (w * w) / (h * h + w * w);
            Console.WriteLine(Math.Floor(Math.Sqrt(sH)) + " " + Math.Floor(Math.Sqrt(sW)));
        }
    }
}
