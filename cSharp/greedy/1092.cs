using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> cranes = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToList();
        int m = int.Parse(Console.ReadLine());
        List<int> boxes = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToList();

        if (boxes.Any(box => box > cranes[0]))
        {
            Console.WriteLine(-1);
            return;
        }

        int time = 0;
        while (boxes.Count > 0)
        {
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (index >= boxes.Count) break;
                if (cranes[i] >= boxes[index])
                {
                    boxes.RemoveAt(index);
                }
                else
                {
                    index++;
                    i--;
                }
            }
            time++;
        }

        Console.WriteLine(time);
    }
}
