using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _4889
    {
        static void Main(string[] args)
        {
            int index = 1;
            while(true)
            {
                string s = Console.ReadLine();
                if (s[0] == '-')
                    break;
                Stack<char> st = new Stack<char>();
                int rc = 0;
                foreach(var c in s)
                {
                    if(c == '{')
                    {
                        st.Push(c);
                    }
                    else
                    {
                        if (st.Count > 0)
                            st.Pop();
                        else
                        {
                            rc++;
                            st.Push('{');
                        }
                            
                    }
                }
                rc += st.Count / 2;
                Console.WriteLine($"{index}. {rc}");
                index++;
            }
        }
    }
}
