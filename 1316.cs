using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1316
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int cnt = 0;
            for(int i=0; i<n; i++)
            {
                string a = Console.ReadLine();
                List<char> ls = new List<char>();
                char pre = ' ';
                int f = 0;
                
                
                foreach(var c in a)
                {
                    if(c == pre)
                    {
                        pre = c;
                        continue;
                    }
                    else
                    {
                        if (ls.Contains(c))
                        {
                            f = 1;
                            break;
                        }
                        else
                        {
                            ls.Add(c);
                            pre = c;
                        }
                            

                    }
                }
                if (f == 0)
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
