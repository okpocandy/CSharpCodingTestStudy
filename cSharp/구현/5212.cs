using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _5212
    {
        static void Main(string[] args)
        {
            int[] rc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int r = rc[0];
            int c = rc[1];
            char[][] ls = new char[r][];
            for (int i = 0; i < r; i++)
            {
                ls[i] = Console.ReadLine().ToCharArray();
            }

            // Padding the grid with a border of '.' characters
            char[][] ls2 = new char[r + 2][];
            string tmp = new string('.', c + 2);
            ls2[0] = tmp.ToCharArray();
            ls2[r + 1] = tmp.ToCharArray();
            for (int i = 1; i < r + 1; i++)
            {
                ls2[i] = ("." + new string(ls[i - 1]) + ".").ToCharArray();
            }

            // Mark the cells that should change
            char[][] result = new char[r + 2][];
            for (int i = 0; i < r + 2; i++)
            {
                result[i] = (char[])ls2[i].Clone();
            }

            for (int i = 1; i < r + 1; i++)
            {
                for (int j = 1; j < c + 1; j++)
                {
                    if (ls2[i][j] == 'X')
                    {
                        int cnt = 0;
                        if (ls2[i - 1][j] == '.') cnt++;
                        if (ls2[i][j - 1] == '.') cnt++;
                        if (ls2[i + 1][j] == '.') cnt++;
                        if (ls2[i][j + 1] == '.') cnt++;

                        if (cnt >= 3)
                        {
                            result[i][j] = '.'; // Mark for change
                        }
                    }
                }
            }
            int minX = r + 1, maxX = 0, minY = c + 1, maxY = 0;
            for (int i = 1; i < r + 1; i++)
            {
                for (int j = 1; j < c + 1; j++)
                {
                    if (result[i][j] == 'X')
                    {
                        minX = Math.Min(minX, i);
                        maxX = Math.Max(maxX, i);
                        minY = Math.Min(minY, j);
                        maxY = Math.Max(maxY, j);
                    }
                }
            }

            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    Console.Write(result[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
