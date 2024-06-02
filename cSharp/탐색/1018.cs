using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _1018
    {
        static void Main(string[] args)
        {
            int[] yx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int y = yx[0];
            int x = yx[1];
            int ans = 987654321;

            char[][] input = new char[y][];
            for (int i = 0; i < y; i++)
            {
                char[] str = Console.ReadLine().ToCharArray();
                input[i] = str;
            }

            for (int i = 0; i < y - 7; i++)
            {
                for (int j = 0; j < x - 7; j++)
                {
                    int count = 0;
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            if (k % 2 == 0)    // y가 짝수
                            {
                                if (l % 2 == 0 && input[k][l] == 'W')  // y가 짝수, x가 짝수면 B가 와야함
                                {
                                    count++;
                                }
                                else if (l % 2 == 1 && input[k][l] == 'B')  //y가 짝수, x가 홀수면 W가 와야함
                                    count++;
                            }
                            else    // y가 홀수
                            {
                                if (l % 2 == 0 && input[k][l] == 'B')  // y가 짝수, x가 짝수면 B가 와야함
                                {
                                    count++;
                                }
                                else if (l % 2 == 1 && input[k][l] == 'W')  //y가 짝수, x가 홀수면 W가 와야함
                                    count++;
                            }
                        }
                    }
                    ans = Math.Min(ans, count);
                    count = 0;
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            if (k % 2 == 0)    // y가 짝수
                            {
                                if (l % 2 == 0 && input[k][l] == 'B')  // y가 짝수, x가 짝수면 B가 와야함
                                {
                                    count++;
                                }
                                else if (l % 2 == 1 && input[k][l] == 'W')  //y가 짝수, x가 홀수면 W가 와야함
                                    count++;
                            }
                            else    // y가 홀수
                            {
                                if (l % 2 == 0 && input[k][l] == 'W')  // y가 짝수, x가 짝수면 B가 와야함
                                {
                                    count++;
                                }
                                else if (l % 2 == 1 && input[k][l] == 'B')  //y가 짝수, x가 홀수면 W가 와야함
                                    count++;
                            }
                        }
                    }


                    ans = Math.Min(ans, count);


                }
            }


            Console.WriteLine(ans);
        }

    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1018
    {
        static void Main(string[] args)
        {
            int[] yx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int y = yx[0];
            int x = yx[1];
            int ans = 987654321;

            char[][] input = new char[y][];
            for (int i = 0; i < y; i++)
            {
                char[] str = Console.ReadLine().ToCharArray();
                input[i] = str;
            }

            for (int i = 0; i < y - 7; i++)
            {
                for (int j = 0; j < x - 7; j++)
                {
                    int count = 0;
                    if (input[i][j] == 'B') //처음이 B일때
                    {
                        for (int k = i; k < i + 8; k++)
                        {
                            for (int l = j; l < j + 8; l++)
                            {
                                if (k % 2 == 0)    // y가 짝수
                                {
                                    if (l % 2 == 0 && input[k][l] == 'W')  // y가 짝수, x가 짝수면 B가 와야함
                                    {
                                        count++;
                                    }
                                    else if (l % 2 == 1 && input[k][l] == 'B')  //y가 짝수, x가 홀수면 W가 와야함
                                        count++;
                                }
                                else    // y가 홀수
                                {
                                    if (l % 2 == 0 && input[k][l] == 'B')  // y가 짝수, x가 짝수면 B가 와야함
                                    {
                                        count++;
                                    }
                                    else if (l % 2 == 1 && input[k][l] == 'W')  //y가 짝수, x가 홀수면 W가 와야함
                                        count++;
                                }
                            }
                        }
                    }
                    else    // 처음이 W 일때
                    {
                        for (int k = i; k < i + 8; k++)
                        {
                            for (int l = j; l < j + 8; l++)
                            {
                                if (k % 2 == 0)    // y가 짝수
                                {
                                    if (l % 2 == 0 && input[k][l] == 'B')  // y가 짝수, x가 짝수면 B가 와야함
                                    {
                                        count++;
                                    }
                                    else if (l % 2 == 1 && input[k][l] == 'W')  //y가 짝수, x가 홀수면 W가 와야함
                                        count++;
                                }
                                else    // y가 홀수
                                {
                                    if (l % 2 == 0 && input[k][l] == 'W')  // y가 짝수, x가 짝수면 B가 와야함
                                    {
                                        count++;
                                    }
                                    else if (l % 2 == 1 && input[k][l] == 'B')  //y가 짝수, x가 홀수면 W가 와야함
                                        count++;
                                }
                            }
                        }
                    }

                    ans = Math.Min(ans, count);


                }
            }


            Console.WriteLine(ans);
        }

    }
}
*/