using System;
using System.Text;

class LCDDisplay
{
    // 각 숫자에 대한 LCD 형식 정의 (가로선: -, 세로선: |)
    static readonly string[][] digits = {
        new string[] { " - ", "| |", "   ", "| |", " - " }, // 0
        new string[] { "   ", "  |", "   ", "  |", "   " }, // 1
        new string[] { " - ", "  |", " - ", "|  ", " - " }, // 2
        new string[] { " - ", "  |", " - ", "  |", " - " }, // 3
        new string[] { "   ", "| |", " - ", "  |", "   " }, // 4
        new string[] { " - ", "|  ", " - ", "  |", " - " }, // 5
        new string[] { " - ", "|  ", " - ", "| |", " - " }, // 6
        new string[] { " - ", "  |", "   ", "  |", "   " }, // 7
        new string[] { " - ", "| |", " - ", "| |", " - " }, // 8
        new string[] { " - ", "| |", " - ", "  |", " - " }  // 9
    };

    static void Main(string[] args)
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split();
        int s = int.Parse(input[0]);
        string n = input[1];

        // LCD 형식의 각 줄을 저장할 StringBuilder 배열
        StringBuilder[] output = new StringBuilder[2 * s + 3];
        for (int i = 0; i < output.Length; i++)
            output[i] = new StringBuilder();

        // 각 숫자에 대해 LCD 형식으로 출력
        foreach (char ch in n)
        {
            int digit = ch - '0';  // 숫자로 변환

            // 첫 번째 줄 (가로선 위)
            output[0].Append(digits[digit][0][0] + new string(digits[digit][0][1], s) + digits[digit][0][2] + " ");

            // 상단 수직선 구간 (s번 반복)
            for (int i = 1; i <= s; i++)
                output[i].Append(digits[digit][1][0] + new string(' ', s) + digits[digit][1][1] + " ");

            // 중간 줄 (가로선 중간)
            output[s + 1].Append(digits[digit][2][0] + new string(digits[digit][2][1], s) + digits[digit][2][2] + " ");

            // 하단 수직선 구간 (s번 반복)
            for (int i = s + 2; i <= 2 * s + 1; i++)
                output[i].Append(digits[digit][3][0] + new string(' ', s) + digits[digit][3][1] + " ");

            // 마지막 줄 (가로선 아래)
            output[2 * s + 2].Append(digits[digit][4][0] + new string(digits[digit][4][1], s) + digits[digit][4][2] + " ");
        }

        // 결과 출력
        foreach (var line in output)
            Console.WriteLine(line.ToString().TrimEnd());
    }
}
