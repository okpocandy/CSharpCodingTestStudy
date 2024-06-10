using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 무지의_먹방_라이브
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int k = 15;
            int[] times = new int[n] {8,6, 4};
            
            int index = 0;

            while (true)
            {
                if (Array.FindIndex(times, e => e != 0) == -1)
                {
                    
                    index = -2;
                    break;
                }
                if (index > 2)
                    index = 0;
                if (times[index] > 0)
                {
                    if (k == 0)
                        break;
                    times[index]--;
                    k--;
                }
                index++;

            }
            Console.WriteLine(index+1);

        }
    }
}
