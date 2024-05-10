using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2439
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inp = int.Parse(input);
            string ans = null;
            for (int i = 0; i < inp; i++)
            {
                ans += "*";
                string tmp = ans.PadLeft(inp);
                Console.WriteLine(tmp);
                
            }
        }
    }
}
