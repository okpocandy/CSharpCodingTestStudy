using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _4641
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double[] ints = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
                if (ints[0] == -1)
                    break;
                int cnt = 0;
                foreach(var i in ints)
                {
                    if(i == 0)
                        continue;
                    if (ints.Contains(i / 2))
                        cnt++;
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
