using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 상하좌우
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] moves = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
            (int y, int x) start = (1,1);
            foreach(char c in moves)
            {
                switch(c)
                {
                    case 'R':
                        {
                            if (start.x < n)
                                start.x++;
                            break;
                        }
                    case 'L':
                        {
                            if (start.x > 1)
                                start.x--;
                            break;
                        }
                    case 'U':
                        {
                            if (start.y > 1)
                                start.y--;
                            break;
                        }
                    case 'D':
                        {
                            if (start.y < n)
                                start.y++;
                            break;
                        }
                }
                Console.WriteLine(start.y + " " + start.x);
            }

        }
    }
}

/*
 
입력:
5
R R R U D D

정답:
3 4


 
 
 
 */