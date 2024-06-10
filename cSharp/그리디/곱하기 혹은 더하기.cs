using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 곱하기_혹은_더하기
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int pre = (int)inp[0] - (int)'0';
            int result = pre;

            for(int i = 1; i < inp.Length; i++)
            {
                int a = (int)inp[i] - (int)'0';
                if (pre == 0 || pre ==1 || a == 0 || a == 1)
                {
                    result += a;
                    pre = a;
                }
                else
                {
                    result *= a;
                    pre = a;
                }
                    
            }
            
            Console.WriteLine(result);
        }
    }
}


/*

inp : 02984
out : 576

inp : 567
out : 210

*/