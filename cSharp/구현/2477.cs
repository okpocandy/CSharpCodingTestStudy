using System;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2477
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] directions = new int[6];
            int[] lengths = new int[6];

            for (int i = 0; i < 6; i++)
            {
                string[] input = Console.ReadLine().Split();
                directions[i] = int.Parse(input[0]);
                lengths[i] = int.Parse(input[1]);
            }

            int maxWidth = 0, maxHeight = 0;
            int minWidth = 0, minHeight = 0;

            for (int i = 0; i < 6; i++)
            {
                if (directions[i] == 1 || directions[i] == 2) // 동/서 방향
                {
                    maxWidth = Math.Max(maxWidth, lengths[i]);
                }
                else if (directions[i] == 3 || directions[i] == 4) // 남/북 방향
                {
                    maxHeight = Math.Max(maxHeight, lengths[i]);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (lengths[i] + lengths[(i + 2) % 6] == maxWidth || lengths[i] + lengths[(i + 2) % 6] == maxHeight)
                {
                    minWidth = lengths[(i + 1) % 6];
                    minHeight = lengths[(i + 2) % 6];
                    break;
                }
            }

            int area = (maxWidth * maxHeight) - (minWidth * minHeight);
            Console.WriteLine(area * k);
        }
    }
}
