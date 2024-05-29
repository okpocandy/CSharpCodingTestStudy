using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 삽입_정령_예제
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 4, 8 };

            for (int i=1; i<array.Length; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }
                    else break;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
