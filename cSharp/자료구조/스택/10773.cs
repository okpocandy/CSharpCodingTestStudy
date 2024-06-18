using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.스택
{
    internal class _10773
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < k; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a != 0)
                    st.Push(a);
                else
                    st.Pop();
            }
            Console.WriteLine(st.Sum());
        }
    }
}
