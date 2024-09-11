# 큐(Queue) 자료구조

큐(Queue)는 **FIFO(First In First Out)**, 즉 선입선출 방식으로 동작하는 자료구조입니다. 줄을 서는 상황을 연상하면 이해가 쉬운데, 데이터는 큐의 끝에 추가되고, 맨 앞에서 제거됩니다. C#에서 큐는 `Queue<T>` 클래스로 제공되며, System.Collections.Generic 네임스페이스에 정의되어 있습니다.

## 1. 기본 사용법

### 큐 초기화

Queue<T> 클래스를 사용하려면 인스턴스를 먼저 생성해야 합니다.

```csharp
using System.Collections.Generic;

Queue<int> myQueue = new Queue<int>();
```

### 요소 추가 (Enqueue)

`Enqueue` 메서드를 사용하여 큐의 뒤쪽에 요소를 추가합니다.

```csharp
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);
```

### 요소 제거 (Dequeue)

`Dequeue` 메서드는 큐의 앞쪽에 있는 요소를 제거하고 반환합니다. 큐가 비어 있을 때 Dequeue를 호출하면 InvalidOperationException이 발생합니다.

```csharp
int frontElement = myQueue.Dequeue(); // frontElement는 1이 됩니다.
```

### 맨 앞 요소 확인 (Peek)

`Peek` 메서드는 큐의 맨 앞에 있는 요소를 제거하지 않고 반환합니다.

```csharp
int frontElement = myQueue.Peek(); // frontElement는 2가 됩니다.
```

### 큐 비우기 (Clear)

`Clear` 메서드를 사용하여 큐의 모든 요소를 제거합니다.

```csharp
myQueue.Clear();
```

## 2. 주요 속성과 메서드

- **Count**: 큐에 있는 요소의 수를 반환합니다.

```csharp
int count = myQueue.Count;
```

- **Contains**: 특정 요소가 큐에 있는지 확인합니다.

```csharp
bool containsTwo = myQueue.Contains(2);
```

- **ToArray**: 큐의 요소를 배열로 복사합니다.

```csharp
int[] array = myQueue.ToArray();
```

- **Enumerator**: 큐의 요소를 열거할 수 있는 열거자를 반환합니다.

```csharp
foreach (var item in myQueue)
{
    Console.WriteLine(item);
}
```

## 3. 큐 사용 예제

아래는 C#에서 큐를 사용하는 간단한 예제입니다.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 큐 초기화
        Queue<int> myQueue = new Queue<int>();

        // 요소 추가
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        // 큐 상태 출력
        Console.WriteLine("Current queue:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // 맨 앞 요소 확인
        Console.WriteLine("Front element is: " + myQueue.Peek());

        // 요소 제거
        Console.WriteLine("Dequeued element is: " + myQueue.Dequeue());

        // 큐 상태 출력
        Console.WriteLine("Current queue after dequeue:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // 큐 비우기
        myQueue.Clear();
        Console.WriteLine("Queue cleared. Current count: " + myQueue.Count);
    }
}
```

## 4. 큐의 응용

큐는 다양한 응용 분야에서 사용됩니다. 대표적인 예는 다음과 같습니다:

1. **BFS (너비 우선 탐색)**: 그래프 또는 트리 탐색에서 사용됩니다.
2. **운영체제 작업 스케줄링**: 작업들이 도착한 순서대로 처리될 때 큐가 사용됩니다.
3. **네트워크 패킷 처리**: 도착한 순서대로 패킷을 처리할 때 큐가 유용합니다.

큐는 FIFO 방식으로 데이터를 처리하는 문제에 적합한 자료구조입니다.
