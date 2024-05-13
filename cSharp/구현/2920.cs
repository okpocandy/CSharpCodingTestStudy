using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2920
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(inputs, int.Parse);
            string ans = "";
            int pre = numbers[0];   
            if (pre == 1)
            {
                for(int i = 1; i < numbers.Length;i++)
                {
                    if(pre + 1 == numbers[i])
                    {
                        pre += 1;
                    }
                    else
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
                }
                Console.WriteLine("ascending");
            }
            else if(pre == 8)
            {

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (pre - 1 == numbers[i])
                    {
                        pre -= 1;
                    }
                    else
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
                }
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed");
            }

        }
    }
}
