using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        int left = 0, right = 0, minDiff = int.MaxValue;

        while (right < n && left <= right)
        {
            int diff = arr[right] - arr[left];

            if (diff >= m)
            {
                minDiff = Math.Min(minDiff, diff);
                left++;
            }
            else
            {
                right++;
            }
        }

        Console.WriteLine(minDiff);
    }
}
