# 알고리즘

1. [그리디 알고리즘](#그리디-알고리즘)

## 그리디 알고리즘

그리디 알고리즘은 매 순간 가장 최적이라고 생각되는 결정을 하는 방식으로 문제를 해결합니다. 이 접근법은 여러 문제에서 간단하고 빠르게 해를 구할 수 있는 장점이 있습니다. 하지만 항상 최적의 해를 보장하지는 않습니다.

### 특징
- **단계별 최적 선택**: 각 단계에서 최적의 선택을 함.
- **근시안적**: 현재 상황에서 최선의 선택을 함.
- **전역 최적 보장 X**: 항상 전체 문제에 대한 최적해를 보장하지는 않음.

### 예시 문제
1. **거스름돈 문제**: 가장 적은 수의 동전으로 거스름돈을 주는 문제.
2. **활동 선택 문제**: 최대한 많은 활동을 수행할 수 있도록 선택하는 문제.
3. **최소 신장 트리 문제**: 최소 비용으로 모든 노드를 연결하는 문제.

### 예제: 거스름돈 문제

다음은 C#으로 구현한 거스름돈 문제의 예제입니다. 주어진 금액에 대해 최소 동전의 수를 구하는 문제입니다.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] coins = { 25, 10, 5, 1 }; // 동전의 종류
        int amount = 63; // 거스름돈
        var result = GetMinimumCoins(coins, amount);

        Console.WriteLine("거스름돈을 주기 위해 필요한 최소 동전의 수:");
        foreach (var coin in result)
        {
            Console.WriteLine($"{coin.Key}원: {coin.Value}개");
        }
    }

    static Dictionary<int, int> GetMinimumCoins(int[] coins, int amount)
    {
        Array.Sort(coins, (a, b) => b.CompareTo(a)); // 내림차순 정렬
        var coinCount = new Dictionary<int, int>();

        foreach (var coin in coins)
        {
            if (amount >= coin)
            {
                int count = amount / coin;
                amount -= count * coin;
                coinCount[coin] = count;
            }
        }

        return coinCount;
    }
}
```

### 예제: 활동 선택 문제
다음은 C#으로 구현한 활동 선택 문제의 예제입니다. 각 활동의 시작 시간과 종료 시간이 주어졌을 때, 최대한 많은 활동을 선택하는 문제입니다.

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Activity(1, 4),
            new Activity(3, 5),
            new Activity(0, 6),
            new Activity(5, 7),
            new Activity(3, 8),
            new Activity(5, 9),
            new Activity(6, 10),
            new Activity(8, 11),
            new Activity(8, 12),
            new Activity(2, 13),
            new Activity(12, 14)
        };

        var selectedActivities = SelectActivities(activities);

        Console.WriteLine("선택된 활동들:");
        foreach (var activity in selectedActivities)
        {
            Console.WriteLine($"활동: 시작 시간 = {activity.Start}, 종료 시간 = {activity.End}");
        }
    }

    static List<Activity> SelectActivities(List<Activity> activities)
    {
        // 종료 시간을 기준으로 활동을 정렬
        activities.Sort((a, b) => a.End.CompareTo(b.End));

        List<Activity> selectedActivities = new List<Activity>();
        selectedActivities.Add(activities[0]);

        int lastEndTime = activities[0].End;

        for (int i = 1; i < activities.Count; i++)
        {
            if (activities[i].Start >= lastEndTime)
            {
                selectedActivities.Add(activities[i]);
                lastEndTime = activities[i].End;
            }
        }

        return selectedActivities;
    }
}

class Activity
{
    public int Start { get; }
    public int End { get; }

    public Activity(int start, int end)
    {
        Start = start;
        End = end;
    }
}
```


그리디 알고리즘은 최적해를 구하는 문제해결 방식 중 하나로, 현재 상황에서 가장 좋다고 생각되는 선택을 하는 방법입니다. 이 방법은 각 단계에서 지역적으로 최적의 선택을 하지만, 결과적으로 전역적으로 최적의 해를 보장하지 않을 수 있습니다. C#으로 그리디 알고리즘을 설명하고, 예제를 추가해드리겠습니다.

markdown
코드 복사
# 알고리즘

1. [그리디 알고리즘](#그리디-알고리즘)

## 그리디 알고리즘

그리디 알고리즘은 매 순간 가장 최적이라고 생각되는 결정을 하는 방식으로 문제를 해결합니다. 이 접근법은 여러 문제에서 간단하고 빠르게 해를 구할 수 있는 장점이 있습니다. 하지만 항상 최적의 해를 보장하지는 않습니다.

### 특징
- **단계별 최적 선택**: 각 단계에서 최적의 선택을 함.
- **근시안적**: 현재 상황에서 최선의 선택을 함.
- **전역 최적 보장 X**: 항상 전체 문제에 대한 최적해를 보장하지는 않음.

### 예시 문제
1. **거스름돈 문제**: 가장 적은 수의 동전으로 거스름돈을 주는 문제.
2. **활동 선택 문제**: 최대한 많은 활동을 수행할 수 있도록 선택하는 문제.
3. **최소 신장 트리 문제**: 최소 비용으로 모든 노드를 연결하는 문제.

### 예제: 거스름돈 문제

다음은 C#으로 구현한 거스름돈 문제의 예제입니다. 주어진 금액에 대해 최소 동전의 수를 구하는 문제입니다.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] coins = { 25, 10, 5, 1 }; // 동전의 종류
        int amount = 63; // 거스름돈
        var result = GetMinimumCoins(coins, amount);

        Console.WriteLine("거스름돈을 주기 위해 필요한 최소 동전의 수:");
        foreach (var coin in result)
        {
            Console.WriteLine($"{coin.Key}원: {coin.Value}개");
        }
    }

    static Dictionary<int, int> GetMinimumCoins(int[] coins, int amount)
    {
        Array.Sort(coins, (a, b) => b.CompareTo(a)); // 내림차순 정렬
        var coinCount = new Dictionary<int, int>();

        foreach (var coin in coins)
        {
            if (amount >= coin)
            {
                int count = amount / coin;
                amount -= count * coin;
                coinCount[coin] = count;
            }
        }

        return coinCount;
    }
}
예제: 활동 선택 문제
다음은 C#으로 구현한 활동 선택 문제의 예제입니다. 각 활동의 시작 시간과 종료 시간이 주어졌을 때, 최대한 많은 활동을 선택하는 문제입니다.

csharp
코드 복사
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Activity(1, 4),
            new Activity(3, 5),
            new Activity(0, 6),
            new Activity(5, 7),
            new Activity(3, 8),
            new Activity(5, 9),
            new Activity(6, 10),
            new Activity(8, 11),
            new Activity(8, 12),
            new Activity(2, 13),
            new Activity(12, 14)
        };

        var selectedActivities = SelectActivities(activities);

        Console.WriteLine("선택된 활동들:");
        foreach (var activity in selectedActivities)
        {
            Console.WriteLine($"활동: 시작 시간 = {activity.Start}, 종료 시간 = {activity.End}");
        }
    }

    static List<Activity> SelectActivities(List<Activity> activities)
    {
        // 종료 시간을 기준으로 활동을 정렬
        activities.Sort((a, b) => a.End.CompareTo(b.End));

        List<Activity> selectedActivities = new List<Activity>();
        selectedActivities.Add(activities[0]);

        int lastEndTime = activities[0].End;

        for (int i = 1; i < activities.Count; i++)
        {
            if (activities[i].Start >= lastEndTime)
            {
                selectedActivities.Add(activities[i]);
                lastEndTime = activities[i].End;
            }
        }

        return selectedActivities;
    }
}

class Activity
{
    public int Start { get; }
    public int End { get; }

    public Activity(int start, int end)
    {
        Start = start;
        End = end;
    }
}
```

### 참조 링크
* [그리디 알고리즘 위키피디아](https://ko.wikipedia.org/wiki/%ED%83%90%EC%9A%95_%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98)

* [C# 공식 문서](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
