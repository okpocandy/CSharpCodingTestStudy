using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 무지의_먹방_라이브
    {
        int solution(int[] food_times, long k)
        {
            int answer = 0;

            int index = 0;
            if (food_times.Sum() <= k)
                answer = -1;
            else
            {
                while (k > 0)
                {
                    if (food_times[index] != 0)
                    {
                        food_times[index]--;
                        k--;
                        index++;
                    }
                    else
                        index++;
                    if (index >= food_times.Length)
                        index = 0;
                }
            }
            for(int i=index; i< food_times.Length; i++)
            {
                if (food_times[i] != 0)
                {
                    answer = index + 1;
                    break;
                }
                    
            }
            

            return answer;
        }
    }
}
