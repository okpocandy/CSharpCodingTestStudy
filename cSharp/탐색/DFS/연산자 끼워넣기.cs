using System;

namespace C_Sharp_Study.cSharp.탐색.DFS
{
    internal class 연산자_끼워넣기
    {
        static int add;
        static int sub;
        static int mul;
        static int div;
        static int n;
        static int min_value;
        static int max_value;
        static int[] ints;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] asmd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            add = asmd[0];
            sub = asmd[1];
            mul = asmd[2];
            div = asmd[3];

            min_value = int.MaxValue;
            max_value = int.MinValue;

            DFS(1, ints[0]);
            Console.WriteLine(max_value);
            Console.WriteLine(min_value);
        }

        static void DFS(int i, int now)
        {
            if (i == n)
            {
                min_value = Math.Min(min_value, now);
                max_value = Math.Max(max_value, now);
            }
            else
            {
                if (add > 0)
                {
                    add--;
                    DFS(i + 1, now + ints[i]);
                    add++;
                }
                if (sub > 0)
                {
                    sub--;
                    DFS(i + 1, now - ints[i]);
                    sub++;
                }
                if (mul > 0)
                {
                    mul--;
                    DFS(i + 1, now * ints[i]);
                    mul++;
                }
                if (div > 0)
                {
                    div--;
                    int temp = now / ints[i];
                    if (now < 0 && ints[i] > 0) temp = -((-now) / ints[i]);
                    if (now > 0 && ints[i] < 0) temp = -(now / (-ints[i]));
                    DFS(i + 1, temp);
                    div++;
                }
            }
        }
    }
}
