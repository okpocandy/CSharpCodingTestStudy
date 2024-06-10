using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 문자열뒤집기
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int result1 = 0;
            int result2 = 0;
            char pre = '0';
            int flg = 0;
            for(int i=0; i<inp.Length; i++)
            {
                if (pre == '0' && inp[i] == '1')
                {
                    result1++;
                }
                pre = inp[i];
            }
            pre = '1';
            for (int i = 0; i < inp.Length; i++)
            {
                if(pre == '1' && inp[i] == '0')
                {
                    result2++;
                }
                pre = inp[i];
            }
            Console.WriteLine(Math.Min(result1, result2));
        }
    }
}

/*

inp : 0001100
out : 1



*/
