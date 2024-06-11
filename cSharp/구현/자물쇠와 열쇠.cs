using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 자물쇠와_열쇠
    {
        static void Main(string[] args)
        {
            int[,] key = new int[3, 3] { { 0, 0, 0 }, { 1, 0, 0 }, { 0, 1, 1 } };
            int[,] lokk = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 0 }, { 1, 0, 1 } };
            int[,] ex_lokk = new int[lokk.GetLength(0) + 4, lokk.GetLength(1) + 4];
            for (int i = 2; i < lokk.GetLength(0) + 2; i++)
            {
                for (int j = 2; j < lokk.GetLength(1) + 2; j++)
                {
                    ex_lokk[i, j] = lokk[i - 2, j - 2];
                }
            }
            bool res = false;
            for (int i = 0; i < 4; i++)
            {
                key = Rotate(key);
                if (Check(key, ex_lokk))
                {
                    res = true;
                    break;
                }
            }
            if (res)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }

        static int[,] Rotate(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    res[j, n - i - 1] = array[i, j];
                }
            }
            return res;
        }

        static bool Check(int[,] key, int[,] ex_lokk)
        {
            for (int i = 0; i < ex_lokk.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < ex_lokk.GetLength(1) - 2; j++)
                {
                    int[,] new_lokk = (int[,])ex_lokk.Clone();
                    for (int k = 0; k < key.GetLength(0); k++)
                    {
                        for (int l = 0; l < key.GetLength(1); l++)
                        {
                            new_lokk[i + k, j + l] += key[k, l];
                        }
                    }

                    if (Sol(new_lokk))
                        return true;
                }
            }
            return false;
        }

        static bool Sol(int[,] new_lokk)
        {
            for (int k = 2; k <= 4; k++)
            {
                for (int l = 2; l <= 4; l++)
                {
                    if (new_lokk[k, l] != 1)
                        return false;
                }
            }
            return true;
        }
    }
}
