using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.구현
{
    internal class TruckBridge
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int w = int.Parse(firstLine[1]);
            int L = int.Parse(firstLine[2]);

            int[] trucks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Queue<int> bridge = new Queue<int>();
            int currentWeight = 0;
            int time = 0;

            for (int i = 0; i < w; i++) bridge.Enqueue(0); 

            int index = 0;
            while (index < n || currentWeight > 0)
            {
                time++;

               
                currentWeight -= bridge.Dequeue();

             
                if (index < n && currentWeight + trucks[index] <= L)
                {
                    bridge.Enqueue(trucks[index]);
                    currentWeight += trucks[index];
                    index++;
                }
                else
                {
                   
                    bridge.Enqueue(0);
                }
            }

            Console.WriteLine(time);
        }
    }
}
