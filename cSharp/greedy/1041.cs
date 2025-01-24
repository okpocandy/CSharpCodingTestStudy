using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        var dice = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long[] oneFace = dice;
        long[] twoFace = {
            dice[0] + dice[1], dice[0] + dice[2], dice[0] + dice[3], dice[0] + dice[4],
            dice[1] + dice[2], dice[1] + dice[3], dice[1] + dice[5],
            dice[2] + dice[4], dice[2] + dice[5],
            dice[3] + dice[4], dice[3] + dice[5],
            dice[4] + dice[5]
        };
        long[] threeFace = {
            dice[0] + dice[1] + dice[2], dice[0] + dice[1] + dice[3],
            dice[0] + dice[2] + dice[4], dice[0] + dice[3] + dice[4],
            dice[1] + dice[2] + dice[5], dice[1] + dice[3] + dice[5],
            dice[2] + dice[4] + dice[5], dice[3] + dice[4] + dice[5]
        };

        long minOneFace = oneFace.Min();
        long minTwoFace = twoFace.Min();
        long minThreeFace = threeFace.Min();

        if (N == 1)
        {
            Console.WriteLine(oneFace.Sum() - oneFace.Max());
            return;
        }

        long corners = 4 * minThreeFace;
        long edges = (4 * (N - 1) + 4 * (N - 2)) * minTwoFace;
        long faces = (4 * (N - 2) * (N - 1) + (N-2) * (N-2))* minOneFace;

        Console.WriteLine(corners + edges + faces);
    }
}