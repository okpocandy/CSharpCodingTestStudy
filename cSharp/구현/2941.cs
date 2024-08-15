using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _2941
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int cnt = 0;
            char pre = s[0];
            char ppre = s[0];
            foreach (var i in s)
            {
                switch (i)
                {
                    case 'j':
                        {
                            if (pre != 'l' && pre != 'n')
                                cnt++;
                        }
                        break;
                    case '-':
                        break;
                    case '=':
                        {
                            if (ppre == 'd' && pre == 'z')
                            {
                                cnt--;
                            }
                        }
                        break;
                    default:
                        cnt++;
                        break;
                }
                ppre = pre;
                pre = i;

            }
            Console.WriteLine(cnt);
        }
    }
}
