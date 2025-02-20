﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 퀵_정렬_예제
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 9, 0, 3, 1, 6, 2, 4, 8 };
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(" ", array));
        }

        static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return;
            int pivot = start;
            int left = start + 1;
            int right = end;
            while(left <= right)
            {
                while(left <= end && array[left] <= array[pivot])
                    left++;
                while (right > start && array[right] >= array[pivot])
                    right--;
                if(left > right)
                {
                    int tmp = array[right];
                    array[right] = array[pivot];
                    array[pivot] = tmp;
                }
                else
                {
                    int tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;
                }
            }
            QuickSort(array, start, right - 1);
            QuickSort(array, right + 1, end);
        }
    }
}
