## 구현 알고리즘

구현 알고리즘은 알고리즘의 개념을 실제 코드로 옮기는 과정입니다. 이는 알고리즘의 논리를 명확하게 이해하고, 이를 정확하게 코드로 표현하는 능력을 요구합니다.

### 주요 개념
- **문제 분해**: 문제를 더 작은 하위 문제로 나누어 해결.
- **자료 구조**: 적절한 자료 구조를 사용하여 데이터를 효율적으로 관리.
- **반복과 조건**: 루프와 조건문을 사용하여 논리 흐름을 제어.
- **효율성**: 알고리즘의 시간 복잡도와 공간 복잡도를 고려.

### 예제 문제
1. **피보나치 수열**: 재귀와 반복을 사용하여 피보나치 수열을 구현.
2. **소수 판별**: 주어진 숫자가 소수인지 판별.
3. **정렬 알고리즘**: 다양한 정렬 알고리즘 구현.

### 예제: 피보나치 수열

피보나치 수열은 첫 두 항이 0과 1이며, 이후의 모든 항은 바로 앞의 두 항의 합인 수열입니다. C#으로 피보나치 수열을 구현하는 방법을 보겠습니다.

```csharp
using System;

class Program
{
    static void Main()
    {
        int n = 10; // 피보나치 수열의 항 수
        Console.WriteLine("피보나치 수열의 {0}번째 항은 {1}입니다.", n, Fibonacci(n));
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
```

### 예제: 소수 판별
소수는 1과 자기 자신만으로 나누어 떨어지는 1보다 큰 자연수입니다. C#으로 소수를 판별하는 방법을 보겠습니다.

```C#
using System;

class Program
{
    static void Main()
    {
        int number = 29; // 소수 판별을 할 숫자
        if (IsPrime(number))
            Console.WriteLine("{0}는 소수입니다.", number);
        else
            Console.WriteLine("{0}는 소수가 아닙니다.", number);
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
```

### 예제: 버블 정렬
버블 정렬은 인접한 두 요소를 비교하여 정렬하는 단순한 정렬 알고리즘입니다. C#으로 버블 정렬을 구현하는 방법을 보겠습니다.

```C#
using System;

class Program
{
    static void Main()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(array);

        Console.WriteLine("정렬된 배열:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j+1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
```
### 참조 링크
* [C# 공식 문서](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
* [알고리즘 위키피디아](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
