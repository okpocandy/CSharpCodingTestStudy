using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _29813
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<(string, int)> q = new Queue<(string, int)>();
            for(int i=0; i<n; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                q.Enqueue((inputs[0], int.Parse(inputs[1])));
            }
            while(q.Count>1)
            {
                (string name, int num) = q.Dequeue();
                for(int i=0; i<num-1; i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                q.Dequeue();
            }
            Console.WriteLine(q.Dequeue().Item1);

        }
    }
}
