using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class Deque
    {
        LinkedList<int> list = new LinkedList<int>();

        public void PushFront(int i)
        {
            list.AddFirst(i);
        }
        public void PushBack(int i)
        {
            list.AddLast(i);
        }

        public void PopFront()
        {
            if (list.Count > 0)
            {
                Console.WriteLine(list.First.Value);
                list.RemoveFirst();
            }
            else
                Console.WriteLine("-1");
            
        }
        public void PopBack()
        {
            if (list.Count > 0)
            {
                Console.WriteLine(list.Last.Value);
                list.RemoveLast();
            }
            else
                Console.WriteLine("-1");
        }
        public void Size()
        {
            Console.WriteLine(list.Count);
        }
        public void Empty()
        {
            if(list.Count == 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
        public void Front()
        {
            if (list.Count > 0)
            {
                Console.WriteLine(list.First.Value);
            }
            else
                Console.WriteLine("-1");

        }
        public void Back()
        {
            if (list.Count > 0)
            {
                Console.WriteLine(list.Last.Value);
            }
            else
                Console.WriteLine("-1");
        }

    }
    class _10866
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Deque dq = new Deque();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                switch (s[0])
                {
                    case "push_front":
                        dq.PushFront(int.Parse(s[1]));
                        break;
                    case "push_back":
                        dq.PushBack(int.Parse(s[1]));
                        break;
                    case "pop_front":
                        dq.PopFront();
                        break;
                    case "pop_back":
                        dq.PopBack();
                        break;
                    case "size":
                        dq.Size();
                        break;
                    case "empty":
                        dq.Empty();
                        break;
                    case "front":
                        dq.Front();
                        break;
                    case "back":
                        dq.Back();
                        break;
                }
            }
        }
    }
}
