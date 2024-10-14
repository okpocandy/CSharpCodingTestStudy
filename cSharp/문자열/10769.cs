using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _10769
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool dot = false;
            bool h = false;
            int index = 0;
            int happy = 0;
            int sad = 0;
            while (index<s.Length)
            {
                if (s[index] == ':')
                {
                    if(index+2 < s.Length)
                    {
                        if (s[index+1] == '-')
                        {
                            if (s[index+2] == ')')
                            {
                                happy++;
                            }
                            else if(s[index+2] == '(')
                            {
                                sad++;
                            }
                        }
                    }
                }
                index++;
            }
            if(happy == sad)
            {
                if (happy == 0 && sad == 0)
                    Console.WriteLine("none");
                else
                    Console.WriteLine("unsure");
            }
            else if (happy < sad)
                Console.WriteLine("sad");
            else
                Console.WriteLine("happy");
        }
    }
}
