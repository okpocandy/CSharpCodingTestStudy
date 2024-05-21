using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.자료구조
{
    internal class _1874
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] ints = new int[count];
            for (int i = 0; i < count; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            int num = 1;
            for (int i = 0; i < ints.Length; i++)
            {
                while (num <= ints[i])
                {
                    if (num <= count)
                    {
                        stack.Push(num++);
                        //Console.WriteLine('+');
                        sb.Append("+\n");
                    }
                }
                if (stack.Peek() == ints[i])
                {
                    stack.Pop();
                    sb.Append("-\n");
                    //Console.WriteLine('-');
                }
            }
            if (stack.Count > 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine(sb.ToString());

        }
    }
}
