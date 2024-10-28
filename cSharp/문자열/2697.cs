using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine()); // 테스트 케이스 개수 입력
        for (int t = 0; t < T; t++)
        {
            string input = Console.ReadLine(); // 테스트 케이스 숫자 입력
            string nextNumber = GetNextPermutation(input); // 다음 수 구하기
            Console.WriteLine(nextNumber); // 결과 출력
        }
    }

    static string GetNextPermutation(string num)
    {
        // 숫자를 문자 배열로 변환
        char[] arr = num.ToCharArray();

        // 뒤에서부터 탐색하며 순서가 깨지는 지점을 찾음
        int i = arr.Length - 2;
        while (i >= 0 && arr[i] >= arr[i + 1])
            i--;

        // 만약 끝까지 순서가 깨지지 않았다면, 더 큰 수가 존재하지 않음
        if (i < 0) return "BIGGEST";

        // i 지점 뒤에서 가장 작은, arr[i]보다 큰 값을 찾음
        int j = arr.Length - 1;
        while (arr[j] <= arr[i])
            j--;

        // i와 j를 스왑
        Swap(arr, i, j);

        // i 이후의 부분을 뒤집어서 사전순으로 가장 작은 형태로 만듦
        Array.Reverse(arr, i + 1, arr.Length - (i + 1));

        // 배열을 문자열로 변환해 반환
        return new string(arr);
    }

    static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
