using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _25757
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            int n = int.Parse(strings[0]);
            string g = strings[1];
            HashSet<string> name = new HashSet<string>();
            for (int i = 0; i < n;i++)
            {
                string s = Console.ReadLine();
                name.Add(s);
            }
            if(g == "Y")
            {
                Console.WriteLine(name.Count);
            }
            else if(g == "F")
                Console.WriteLine((name.Count)/2);
            else
                Console.WriteLine((name.Count) / 3);
        }
    }
}
