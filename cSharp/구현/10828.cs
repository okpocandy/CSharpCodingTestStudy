using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _10828
    {
        static void Main(string[] args)
        {
            sstack st = new sstack();
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i=0; i<n; i++)
            {
                string[] inp = Console.ReadLine().Split();
                string com = inp[0];
                
                switch(com)
                {
                    case "push":
                        st.Push(int.Parse(inp[1]));
                        break;
                    case "pop":
                        sb.Append(st.Pop() + "\n");
                        break;
                    case "size":
                        sb.Append(st.Size() + "\n");
                        break;
                    case "empty":
                        sb.Append(st.Empty() + "\n");
                        break;
                    case "top":
                        sb.Append(st.Top() + "\n");
                        break;
                }

            }
            Console.WriteLine(sb);
        }
        
    }

    class sstack
    {
        private List<int> st = new List<int>();
        public void Push(int i)
        {
            st.Add(i);
        }
        public int Pop()
        {
            if (st.Count == 0)
                return -1;
            else
            {
                int a = st.Last();
                st.RemoveAt(st.Count-1);
                return a;
            }
                
        }
        public int Top()
        {
            if (st.Count == 0)
                return -1;
            else
                return st[^1];
        }
        public int Size()
        {
            return st.Count;
        }
        public int Empty()
        {
            if (Size() == 0) return 1;
            else return 0;
        }

    }
}
