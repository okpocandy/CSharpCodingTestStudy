using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    class _1541
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            string[] parts = expression.Split('-');

            // 첫 번째 부분은 덧셈으로만 계산
            int result = SumParts(parts[0]);

            // 나머지 부분은 모두 뺄셈으로 계산
            for (int i = 1; i < parts.Length; i++)
            {
                result -= SumParts(parts[i]);
            }

            Console.WriteLine(result);
        }

        // +로 구분된 각 부분을 합산하는 메소드
        static int SumParts(string part)
        {
            string[] numbers = part.Split('+');
            int sum = 0;
            foreach (string number in numbers)
            {
                sum += int.Parse(number);
            }
            return sum;
        }
    }
}
