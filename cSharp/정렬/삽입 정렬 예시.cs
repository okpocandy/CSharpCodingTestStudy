using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class 삽입_정렬_예시
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 4, 8 };

            for(int i=1; i<array.Length; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                    else
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
