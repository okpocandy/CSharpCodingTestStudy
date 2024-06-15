using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조.큐
{
    internal class _10845
    {
        static void Main(string[] args)
        {
            Q q = new Q();
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string[] inp = Console.ReadLine().Split();
                switch(inp[0])
                {
                    case "push":
                        q.Push(int.Parse(inp[1]));
                        break;
                    case "pop":
                        sb.Append(q.Pop() + "\n");
                        break;
                    case "size":
                        sb.Append(q.Size() + "\n");
                        break;
                    case "empty":
                        sb.Append(q.Empty() + "\n");
                        break;
                    case "front":
                        sb.Append(q.Front() + "\n");
                        break;
                    case "back":
                        sb.Append(q.Back() + "\n");
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
    class Q
    {
        private List<int> ints = new List<int>();
        public void Push(int i)
        {
            ints.Add(i);
        }
        public int Pop()
        {
            if (ints.Count > 0)
            {
                int tmp = ints[0];
                ints.RemoveAt(0);
                return tmp;
            }
            else
                return -1;
        }
        public int Size()
        {
            return ints.Count;
        }
        public int Empty()
        {
            if(ints.Count > 0)
            {
                return 0;
            }
            else
                return 1;
        }
        public int Front()
        {
            if (ints.Count > 0)
            {
                return ints[0];
            }
            else
                return -1;
        }
        public int Back()
        {
            if (ints.Count > 0)
            {
                return ints[^1];
            }
            else
                return -1;
        }
    }
}
