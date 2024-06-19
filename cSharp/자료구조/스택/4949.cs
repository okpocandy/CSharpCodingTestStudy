using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.스택
{
    internal class _4949
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string chars = Console.ReadLine();
                Stack<char> st = new Stack<char>();
                if (chars == ".")
                    break;
                string ans = "";
                foreach (var c in chars)
                {
                    if (c == '(')
                    {
                        st.Push(c);
                    }
                    else if (c == ')')
                    {
                        if (st.Count == 0)
                            ans = "no";
                        else
                        {
                            int a = st.Pop();
                            if (a == '[')
                                ans = "no";
                        }

                    }
                    else if (c == '[')
                        st.Push(c);
                    else if (c == ']')
                    {
                        if (st.Count == 0)
                            ans = "no";
                        else
                        {
                            int a = st.Pop();
                            if (a == '(')
                                ans = "no";
                        }

                    }
                }
                if (ans.Equals("no"))
                    Console.WriteLine("no");
                else
                {
                    if (st.Count == 0)
                        Console.WriteLine("yes");
                    else
                        Console.WriteLine("no");
                }
            }
        }
    }
}
