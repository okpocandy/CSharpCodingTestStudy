using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 이항_계수1
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int ans = 0;
            if( k == 0 ) { ans = 1; }
            else
                ans = fact(n)/(fact(k) * fact(n-k));
            Console.WriteLine(ans);
        }
        
        static int fact(int i)
        {
            if (i == 1 || i == 0)
            {
                return 1;

            }
            else
                return i * fact(i - 1);
        }
        

    }
}
