using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.수학
{
    internal class _13909
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i=1; i*i<=n; i++)
            {
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
