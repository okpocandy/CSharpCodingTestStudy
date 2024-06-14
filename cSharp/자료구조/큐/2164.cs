using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2164
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            for(int i=0; i<n; i++)
            {
                q.Enqueue(i + 1);
            }
            while(true)
            {
                
                if(q.Count == 1 )
                {
                    break;
                }
                q.Dequeue();
                int tmp = q.Dequeue();
                q.Enqueue(tmp);
            }
            Console.WriteLine(q.Dequeue());
        }
    }
}
