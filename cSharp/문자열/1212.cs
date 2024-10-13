using System;
using System.Text;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1212
    {
        static void Main(string[] args)
        {
            string octal = Console.ReadLine();

            // StringBuilder를 이용해 결과를 저장
            StringBuilder binary = new StringBuilder();

            // 첫 번째 자리만 따로 변환 (앞의 0 제거)
            binary.Append(Convert.ToString(octal[0] - '0', 2));

            // 나머지 자리는 항상 3자리로 변환
            for (int i = 1; i < octal.Length; i++)
            {
                binary.Append(Convert.ToString(octal[i] - '0', 2).PadLeft(3, '0'));
            }

            Console.WriteLine(binary.ToString());
        }
    }
}
