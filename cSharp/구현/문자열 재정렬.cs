using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 문자열_재정렬
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char[] chars = a.ToCharArray();
            List<char> charL = new List<char>();
            List<int> charN = new List<int>();
            foreach (char c in chars)
            {
                if (c >= 'A')
                    charL.Add(c);
                else
                    charN.Add((int)c-(int)'0');
            }
            charL.Sort();
            int b = charN.Sum();

            Console.WriteLine(String.Join("", charL.ToArray()) + b.ToString());
        }
    }
}

/*


inp:
K1KA5CB7

out:
ABCKK13

inp:
AJKDLSI412K4JSJ9D

out:
ADDIJJKKLSS20


*/
