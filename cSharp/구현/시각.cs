using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 시각
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int hour = 0;
            int minute = 0;
            int second = 0;
            int count = 0;

            for(int i=0; i <= N; i++)
            {       
                for(int j=0; j < 60; j++)
                {
                    for(int k=0; k < 60; k++)
                    {
                        if((i.ToString() + j.ToString() + k.ToString()).Contains("3"))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);  
        }
    }
}
