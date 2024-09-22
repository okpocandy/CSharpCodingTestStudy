using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Study.cSharp.문자열
{
    internal class _13417
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i< t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                LinkedList<string> ls = new LinkedList<string>();
                string[] chars = Console.ReadLine().Split();
                ls.AddLast(chars[0]);
                string mi = chars[0];
                for(int j=1; j< chars.Length; j++)
                {
                    if (chars[j].CompareTo(mi) <= 0)
                    {
                        ls.AddFirst(chars[j]);
                        mi = chars[j];
                    }
                    else
                    {
                        ls.AddLast(chars[j]);
                    }
                }
                Console.WriteLine(string.Join("", ls));
            }
        }
    }
}
