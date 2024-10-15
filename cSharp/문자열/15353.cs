using System;
using System.Numerics;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _ABBig
    {
        static void Main(string[] args)
        {
            // 입력받아 공백으로 분리
            string[] input = Console.ReadLine().Split();

            // 두 정수를 BigInteger로 변환
            BigInteger A = BigInteger.Parse(input[0]);
            BigInteger B = BigInteger.Parse(input[1]);

            // A + B의 결과 출력
            Console.WriteLine(A + B);
        }
    }
}
