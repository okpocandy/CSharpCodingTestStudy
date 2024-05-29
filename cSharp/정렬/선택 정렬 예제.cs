using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 선택_정렬_예제
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 4, 8 };

            for (int i = 0; i < array.Length; i++)
            {
                int min_index = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[min_index] > array[j])
                    {
                        min_index = j;
                    }
                }
                if (array[i] > array[min_index])
                {
                    int tmp = array[i];
                    array[i] = array[min_index];
                    array[min_index] = tmp;
                }
                

            }
            
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
