using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp
{
    internal class _10799
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<char> st = new Stack<char>();
            int ans = 0;
            int cnt = 0;
            char pre = '(';
            foreach(var i in s)
            {
                if(i == '(')
                {
                    st.Push(i);
                    cnt++;
                    pre = '(';
                }
                    
                else
                {
                    if(pre == '(')
                    {
                        st.Pop();
                        cnt--;
                        ans += cnt;
                    }
                    else
                    {
                        cnt--;
                        ans++;
                    }
                    pre = ')';
                }
            }
            Console.WriteLine(ans);
        }
    }
}
