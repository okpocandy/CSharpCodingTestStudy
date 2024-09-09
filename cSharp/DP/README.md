# 다이내믹 프로그래밍(DP) 알고리즘

다이내믹 프로그래밍(Dynamic Programming, DP)은 **복잡한 문제를 작은 하위 문제로 나누어** 그 결과를 저장하고 재활용함으로써 **효율적으로 문제를 해결하는** 알고리즘 기법입니다. **동적 계획법**이라고도 하며, 주로 **최적화 문제**나 **계산을 중복해서 수행할 수 있는 문제**에 많이 사용됩니다.

DP의 핵심 개념은 **메모이제이션(Memoization)** 또는 **타뷸레이션(Tabulation)** 을 통해 중복되는 계산을 제거하는 것입니다.

## DP 문제 해결 전략

1. **상태(State)**: 문제를 해결하기 위해 필요한 상태를 정의합니다. 즉, 하위 문제를 나타내는 변수를 정의합니다.
2. **점화식(Recurrence Relation)**: 하위 문제 간의 관계를 정의합니다. 즉, 상태 간의 전이 관계를 수립합니다.
3. **초기 조건(Base Case)**: 가장 작은 문제(기본 문제)에 대한 해답을 정의합니다.
4. **최적 부분 구조(Optimal Substructure)**: 문제를 작은 하위 문제들로 나누어 해결한 뒤, 그 결과를 조합하여 전체 문제를 해결할 수 있어야 합니다.
5. **중복 부분 문제(Overlapping Subproblems)**: 동일한 작은 문제들이 여러 번 반복해서 나타나는 경우, 이를 한 번만 계산하고 재사용합니다.

## DP의 두 가지 방식

1. **Top-down(상향식)**: 재귀 호출과 메모이제이션(Memoization)을 이용하여 하위 문제의 결과를 저장하고, 동일한 계산을 반복하지 않도록 합니다.
   
2. **Bottom-up(하향식)**: 타뷸레이션(Tabulation) 기법을 사용하여, 가장 작은 문제부터 차례대로 해결해 나가면서 문제의 답을 구합니다. 재귀 호출을 사용하지 않고 반복문을 주로 사용합니다.

## DP 알고리즘 구현 예시

### 피보나치 수열

피보나치 수열을 DP로 구현한 예시입니다.

#### Top-down(메모이제이션) 방식
```csharp
using System;

class FibonacciTopDown
{
    static int[] dp = new int[100];

    static void Main(string[] args)
    {
        Array.Fill(dp, -1);  // dp 배열을 -1로 초기화

        int n = 10;
        Console.WriteLine(Fibonacci(n));
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        // 이미 계산된 값이면 바로 반환
        if (dp[n] != -1) return dp[n];

        // 계산된 값을 dp 배열에 저장하고 반환
        dp[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        return dp[n];
    }
}
```

### Bottom-up(타뷸레이션) 방식
```csharp
using System;

class FibonacciBottomUp
{
    static void Main(string[] args)
    {
        int n = 10;
        Console.WriteLine(Fibonacci(n));
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}
```

### DP 알고리즘의 시간 복잡도

다이내믹 프로그래밍의 시간 복잡도는 일반적으로 **O(n)** 입니다. 이는 각 하위 문제를 한 번씩만 계산하며, 중복되는 계산을 방지하기 때문입니다. 문제에 따라 복잡도가 다를 수 있지만, 일반적으로 DP는 동일한 문제를 반복해서 계산하지 않는다는 점에서 큰 성능 향상을 제공합니다.


### DP의 응용 분야
* **최단 경로 문제**: 예를 들어, 그래프에서 한 점에서 다른 점까지의 최단 경로를 찾는 문제를 DP로 해결할 수 있습니다. (예: 벨만-포드 알고리즘)
* **배낭 문제**: 물건을 배낭에 넣을 때 최대 가치를 얻는 방법을 찾는 문제를 해결할 때 DP가 사용됩니다.
* **문자열 비교 문제**: 두 문자열의 유사도를 계산하는 문제 (예: 편집 거리 계산)
* **게임 이론 문제**: 최적의 플레이 전략을 세우는 문제를 해결할 때도 DP가 사용됩니다.

### DP의 장점과 단점
**장점**

  * 중복 계산을 줄여 알고리즘의 성능을 크게 향상시킬 수 있습니다.
  * 분할 정복 기법과 결합하여 최적화 문제를 해결할 수 있습니다.

**단점**

  * 메모리 사용량이 많아질 수 있습니다.
  * 문제의 최적 부분 구조와 중복 부분 문제 특성을 파악하기 어려운 경우가 있습니다.

### 참조 링크
* [다이내믹 프로그래밍 위키피디아](https://ko.wikipedia.org/wiki/%EB%8F%99%EC%A0%81_%EA%B3%84%ED%9A%8D%EB%B2%95)
