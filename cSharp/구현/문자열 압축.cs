using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 문자열_압축
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int max_length = (inp.Length / 2)+1;
            int ans = inp.Length;
            for(int step=1; step<max_length; step++)
            {
                string res = "";
                int cnt = 1;
                string pre = inp[0..step];
               
                for(int j=step; j < inp.Length;j += step )
                {
                    string now = "";
                    if (j + step >= inp.Length)
                        now = inp[j..inp.Length];
                    else
                        now = inp[j..(j + step)];
                    if (pre.Equals(now))
                        cnt++;
                    else
                    {
                        if (cnt >= 2) { res += cnt.ToString() + pre; }
                        else { res += pre; }
                        pre = now;
                        cnt = 1;
                    }

                }
                if (cnt >= 2) { res += cnt.ToString() + pre; }
                else { res += pre; }
                Console.WriteLine(res);
                ans = Math.Min(ans, res.Length);
            }
            Console.WriteLine(ans);

        }
    }
}

/*
inp:
aabbaccc 

out:
7

inp:
ababcdcdababcdcd

out: 9

int:
abcabcdede

out:
8

inp:
abcabcabcabcdedededede

out: 
14

inp:
xababcdcdababcdcd

out: 17

*/