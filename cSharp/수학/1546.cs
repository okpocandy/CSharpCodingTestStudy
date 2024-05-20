using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _1546
    {
        static void Main(string[] args)
        {
            float N = int.Parse(Console.ReadLine());
            float[] scores = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            float max_score = scores.Max();
            float sum = 0;
            for (int i = 0; i < N; i++)
            {
                scores[i] = scores[i] / max_score * 100;
                sum += scores[i];
            }
            Console.WriteLine(sum / N);
        }
    }
}
