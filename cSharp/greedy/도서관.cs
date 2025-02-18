using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.greedy
{
    internal class 도서관
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] books = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> lb = new List<int>() { 0 };
            List<int> rb = new List<int>() { 0 };
            foreach(var i in books)
            {
                if(i > 0)
                    rb.Add(i);
                else
                    lb.Add(i);
            }
            rb.Sort((a,b) => b.CompareTo(a));
            lb.Sort();
            int rs = 0;
            int ls = 0;
            for(int i=0; i<rb.Count; i+= m)
            {
                rs += rb[i] * 2;
            }
            for(int i=0; i<lb.Count; i+= m)
            {
                ls += -lb[i] * 2;
            }
            int maxb = Math.Max(rb.First(), -lb.First());
            Console.WriteLine(rs + ls - maxb);

        }
    }
}
