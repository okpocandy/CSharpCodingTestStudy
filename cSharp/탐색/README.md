탐색 알고리즘은 데이터 구조에서 특정 데이터를 찾는 방법을 정의합니다.
대표적인 탐색 알고리즘으로는 DFS(깊이 우선 탐색), BFS(너비 우선 탐색), 이진 탐색 등이 있습니다.

# 탐색 알고리즘

1. [너비 우선 탐색(BFS)](#너비-우선-탐색BFS)
   
2. [깊이 우선 탐색(DFS)](#깊이-우선-탐색DFS)
   
3. [이진 탐색(Binary Search)](#이진탐색-알고리즘)

## 너비 우선 탐색(BFS)

너비 우선 탐색(BFS, Breadth-First Search)은 **그래프나 트리에서 가까운 노드부터 탐색**하는 알고리즘입니다.
BFS는 주로 **최단 경로를 찾거나 레벨 순회(Level Order Traversal)** 를 할 때 사용됩니다. 
BFS는 **큐 자료구조**를 사용하여 구현할 수 있습니다.

![Animated_BFS](https://github.com/okpocandy/CSharpCodingTestStudy/assets/71319122/ac4a4350-40e2-420e-97eb-d8abdfb50696)


### BFS 알고리즘 설명

1. 시작 노드를 큐에 넣고 방문 처리합니다.
2. 큐에서 노드를 하나씩 꺼내 해당 노드의 인접 노드 중 방문하지 않은 노드를 모두 큐에 넣고 방문 처리합니다.
3. 큐가 빌 때까지 2번 과정을 반복합니다.

### BFS 구현 예제 (C#)

아래는 C#으로 구현한 BFS 알고리즘 예제입니다.

```csharp
using System;
using System.Collections.Generic;

namespace CSharpStudy.Algorithms
{
    class BFSExample
    {
        static void Main(string[] args)
        {
            // 그래프 초기화 (노드 번호는 1부터 시작)
            List<int>[] graph = {
                new List<int> { },        // 0번 노드 (사용 안함)
                new List<int> { 2, 3, 8 },
                new List<int> { 1, 7 },
                new List<int> { 1, 4, 5 },
                new List<int> { 3, 5 },
                new List<int> { 3, 4 },
                new List<int> { 7 },
                new List<int> { 2, 6, 8 },
                new List<int> { 1, 7 }
            };

            // 방문 처리를 위한 배열 초기화
            bool[] visited = new bool[9];
            
            // BFS 실행
            BFS(1, graph, visited);
        }

        static void BFS(int startNode, List<int>[] graph, bool[] visited)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            visited[startNode] = true;

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                Console.WriteLine(node);

                foreach (var next in graph[node])
                {
                    if (!visited[next])
                    {
                        queue.Enqueue(next);
                        visited[next] = true;
                    }
                }
            }
        }
    }
}
```

### BFS 알고리즘의 특징

* 시간 복잡도: O(V + E) (V는 정점의 수, E는 간선의 수)
* 공간 복잡도: O(V)
* 특징: 모든 간선의 가중치가 동일한 경우 최단 경로를 찾을 수 있습니다.

### BFS의 응용 분야

* 최단 경로 찾기: 무가중치 그래프에서 최단 경로를 찾는 데 사용됩니다.
* 레벨 순회: 트리 구조에서 각 레벨의 노드를 방문하는 데 사용됩니다.
* 친구 추천 알고리즘: 소셜 네트워크에서 가까운 친구를 추천하는 데 사용됩니다.

### 참조 링크
* [너비 우선 탐색 위키피디아](https://ko.wikipedia.org/wiki/%EB%84%88%EB%B9%84_%EC%9A%B0%EC%84%A0_%ED%83%90%EC%83%89)

## 깊이 우선 탐색(DFS)

깊이 우선 탐색(DFS, Depth-First Search)은 **그래프나 트리에서 깊은 부분을 우선적으로 탐색**하는 알고리즘입니다.
DFS는 **스택 자료구조**를 사용하여 구현할 수 있으며, **재귀적으로도 구현**이 가능합니다.

![Depth-First-Search](https://github.com/okpocandy/CSharpCodingTestStudy/assets/71319122/bb0c5cae-3a3d-4792-b2fe-40b57f6d47c6)



### DFS 알고리즘 설명

1. 시작 노드를 스택에 넣고 방문 처리합니다.
2. 스택에서 노드를 하나씩 꺼내 해당 노드의 인접 노드 중 방문하지 않은 노드를 모두 스택에 넣고 방문 처리합니다.
3. 스택이 빌 때까지 2번 과정을 반복합니다.

### DFS 구현 예제 (C#)

아래는 C#으로 구현한 DFS 알고리즘 예제입니다.

#### 재귀를 사용한 DFS

```csharp
using System;
using System.Collections.Generic;

namespace CSharpStudy.Algorithms
{
    class DFSExample
    {
        static void Main(string[] args)
        {
            // 그래프 초기화 (노드 번호는 1부터 시작)
            List<int>[] graph = {
                new List<int> { },        // 0번 노드 (사용 안함)
                new List<int> { 2, 3, 8 },
                new List<int> { 1, 7 },
                new List<int> { 1, 4, 5 },
                new List<int> { 3, 5 },
                new List<int> { 3, 4 },
                new List<int> { 7 },
                new List<int> { 2, 6, 8 },
                new List<int> { 1, 7 }
            };

            // 방문 처리를 위한 배열 초기화
            bool[] visited = new bool[9];

            // DFS 실행
            DFS(1, graph, visited);
        }

        static void DFS(int node, List<int>[] graph, bool[] visited)
        {
            visited[node] = true;
            Console.WriteLine(node);

            foreach (var next in graph[node])
            {
                if (!visited[next])
                {
                    DFS(next, graph, visited);
                }
            }
        }
    }
}
```

#### 스택을 사용한 DFS
```C#
using System;
using System.Collections.Generic;

namespace CSharpStudy.Algorithms
{
    class DFSExample
    {
        static void Main(string[] args)
        {
            // 그래프 초기화 (노드 번호는 1부터 시작)
            List<int>[] graph = {
                new List<int> { },        // 0번 노드 (사용 안함)
                new List<int> { 2, 3, 8 },
                new List<int> { 1, 7 },
                new List<int> { 1, 4, 5 },
                new List<int> { 3, 5 },
                new List<int> { 3, 4 },
                new List<int> { 7 },
                new List<int> { 2, 6, 8 },
                new List<int> { 1, 7 }
            };

            // 방문 처리를 위한 배열 초기화
            bool[] visited = new bool[9];

            // DFS 실행
            DFS(1, graph, visited);
        }

        static void DFS(int startNode, List<int>[] graph, bool[] visited)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(startNode);
            visited[startNode] = true;

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                Console.WriteLine(node);

                foreach (var next in graph[node])
                {
                    if (!visited[next])
                    {
                        stack.Push(next);
                        visited[next] = true;
                    }
                }
            }
        }
    }
}
```
### DFS 알고리즘의 특징

* 시간 복잡도: O(V + E) (V는 정점의 수, E는 간선의 수)
* 공간 복잡도: O(V) (재귀를 사용하는 경우, 호출 스택의 크기)
* 특징: 깊이 우선으로 탐색하므로, 경로의 길이가 긴 경우에 유리합니다.

### DFS의 응용 분야

* 미로 찾기: 미로의 출발점에서 도착점까지의 경로를 찾을 때 사용됩니다.
* 사이클 검출: 그래프에서 사이클이 존재하는지 여부를 판단할 때 사용됩니다.
* 연결 요소 찾기: 그래프에서 연결 요소를 찾는 데 사용됩니다.

### 참조
* [깊이 우선 탐색 위키피디아](https://ko.wikipedia.org/wiki/%EA%B9%8A%EC%9D%B4_%EC%9A%B0%EC%84%A0_%ED%83%90%EC%83%89)

## 이진탐색 알고리즘

이진탐색(Binary Search)은 정렬된 배열에서 특정 값을 효율적으로 찾는 탐색 알고리즘입니다. 배열의 중간 요소를 선택하여 찾고자 하는 값과 비교하고, 비교 결과에 따라 탐색 범위를 반씩 줄여가며 값을 찾습니다. 이진탐색은 분할 정복 알고리즘의 일종입니다.

![image](https://github.com/okpocandy/CSharpCodingTestStudy/assets/71319122/cf05b9ca-18df-4295-8b2c-7c128f499600)

### 이진탐색 알고리즘 설명

1. 배열의 중간 값을 찾습니다.
2. 중간 값이 찾고자 하는 값과 같으면 탐색을 종료합니다.
3. 찾고자 하는 값이 중간 값보다 작으면 배열의 왼쪽 반을 대상으로 다시 탐색합니다.
4. 찾고자 하는 값이 중간 값보다 크면 배열의 오른쪽 반을 대상으로 다시 탐색합니다.
5. 배열의 범위가 좁아져서 더 이상 탐색할 수 없을 때까지 이 과정을 반복합니다.

### 이진탐색 구현 예제 (C#)

아래는 C#으로 구현한 이진탐색 알고리즘 예제입니다.

#### 반복문을 사용한 이진탐색

```csharp
using System;

namespace CSharpStudy.Algorithms
{
    class BinarySearchExample
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 7;

            int index = BinarySearch(array, target);
            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // 요소를 찾지 못한 경우
        }
    }
}
```

#### 재귀를 사용한 이진탐색

```C#
using System;

namespace CSharpStudy.Algorithms
{
    class BinarySearchExample
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 7;

            int index = BinarySearch(array, target, 0, array.Length - 1);
            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
        }

        static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1; // 요소를 찾지 못한 경우
            }

            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                return BinarySearch(array, target, mid + 1, right);
            }
            else
            {
                return BinarySearch(array, target, left, mid - 1);
            }
        }
    }
}
```

### 이진탐색 알고리즘의 특징

* **시간 복잡도**: O(log n) (n은 배열의 요소 수)
* **공간 복잡도**: O(1) (반복문 사용 시), O(log n) (재귀 호출 스택 사용 시)
* **특징**: 정렬된 배열에서만 사용 가능하며, 검색 속도가 매우 빠릅니다.

### 이진탐색의 응용 분야
* **데이터 검색**: 큰 데이터베이스에서 데이터를 빠르게 검색할 때 사용됩니다.
* **정렬된 배열에서의 위치 찾기**: 정렬된 배열에서 특정 요소의 위치를 찾을 때 사용됩니다.
* **효율적인 탐색**: 탐색 범위를 반씩 줄이므로 매우 효율적인 탐색이 가능합니다.
  
이진탐색은 효율적인 탐색 알고리즘으로, 많은 데이터가 정렬된 상태에서 매우 빠른 탐색을 가능하게 합니다.

### 참조
* [이진 검색 알고리즘 위키피디아]([https://ko.wikipedia.org/wiki/%EA%B9%8A%EC%9D%B4_%EC%9A%B0%EC%84%A0_%ED%83%90%EC%83%89](https://ko.wikipedia.org/wiki/%EC%9D%B4%EC%A7%84_%EA%B2%80%EC%83%89_%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98))
