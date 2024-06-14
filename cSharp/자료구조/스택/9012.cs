using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _9012
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int i=0; i<n; i++)
            {
                string chars = Console.ReadLine();
                Stack<char> st = new Stack<char>();
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
                            ans = "NO";
                        else
                            st.Pop();
                    }
                }
                if (ans.Equals("NO"))
                    Console.WriteLine("NO");
                else
                {
                    if (st.Count == 0)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
            }
            
        }
    }
}
