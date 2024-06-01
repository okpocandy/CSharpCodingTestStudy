using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _5576
    {
        static void Main(string[] args)
        {
            List<int> W = new List<int>();
            List<int> K = new List<int>();
            for(int i=0; i<10; i++  )
            {
                int input = int.Parse( Console.ReadLine() );
                W.Add( input );
            }
            for (int i = 0; i < 10; i++)
            {
                int input = int.Parse(Console.ReadLine());
                K.Add( input );
            }
            W.Sort();
            K.Sort();
            Console.Write(W[9] + W[8] + W[7]);
            Console.Write(' ');
            Console.Write(K[9] + K[8] + K[7]);

        }
    }
}
