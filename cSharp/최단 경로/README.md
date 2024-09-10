# 최단 경로 알고리즘

최단 경로 알고리즘은 그래프에서 두 정점 간의 가장 짧은 경로를 찾는 알고리즘입니다. 다양한 응용 분야에서 사용되며, 대표적인 알고리즘으로는 다익스트라 알고리즘, 벨만-포드 알고리즘, 플로이드-워셜 알고리즘 등이 있습니다.

## 1. [다익스트라 알고리즘](#다익스트라-알고리즘)
   
## 2. [벨만-포드 알고리즘](#벨만-포드-알고리즘)

## 3. [플로이드-워셜 알고리즘](#플로이드-워셜-알고리즘)

---

## 다익스트라 알고리즘

**다익스트라 알고리즘(Dijkstra's Algorithm)** 은 **가중치가 양수인 그래프**에서 시작 정점으로부터 다른 모든 정점까지의 최단 경로를 찾는 알고리즘입니다. 우선순위 큐(Heap)을 사용하여 효율적으로 구현할 수 있습니다.

### 다익스트라 알고리즘 동작 과정
1. 시작 정점을 선택하고, 그 정점까지의 거리를 0으로 설정합니다.
2. 방문하지 않은 정점 중 가장 가까운 정점을 선택하고, 그 정점까지의 거리를 확정합니다.
3. 해당 정점과 연결된 인접한 정점들의 거리를 업데이트합니다.
4. 모든 정점의 거리가 확정될 때까지 2, 3번 과정을 반복합니다.

### 다익스트라 알고리즘 구현 예제 (C#)

```csharp
using System;
using System.Collections.Generic;

class Dijkstra
{
    class Edge
    {
        public int To;
        public int Weight;
        public Edge(int to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }

    static void Main(string[] args)
    {
        List<Edge>[] graph = new List<Edge>[]
        {
            new List<Edge>(),         // 0번 노드는 사용하지 않음
            new List<Edge> { new Edge(2, 2), new Edge(3, 5), new Edge(4, 1) },
            new List<Edge> { new Edge(3, 3), new Edge(4, 2) },
            new List<Edge> { new Edge(2, 3), new Edge(6, 5) },
            new List<Edge> { new Edge(3, 3), new Edge(5, 1) },
            new List<Edge> { new Edge(3, 1), new Edge(6, 2) },
            new List<Edge>()
        };

        int[] dist = DijkstraAlgorithm(graph, 1, 6);

        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Distance from 1 to {i}: {dist[i]}");
        }
    }

    static int[] DijkstraAlgorithm(List<Edge>[] graph, int start, int n)
    {
        int[] dist = new int[n + 1];
        for (int i = 0; i <= n; i++) dist[i] = int.MaxValue;
        dist[start] = 0;

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(start, 0);

        while (pq.Count > 0)
        {
            int node = pq.Dequeue();
            foreach (var edge in graph[node])
            {
                int next = edge.To;
                int newDist = dist[node] + edge.Weight;
                if (newDist < dist[next])
                {
                    dist[next] = newDist;
                    pq.Enqueue(next, newDist);
                }
            }
        }

        return dist;
    }
}
```

### 다익스트라 알고리즘의 특징
- **시간 복잡도**: O((V + E)log V) (V는 정점의 수, E는 간선의 수)
- **단점**: 간선의 가중치가 음수일 경우에는 사용할 수 없습니다.

---

## 벨만-포드 알고리즘

**벨만-포드 알고리즘(Bellman-Ford Algorithm)** 은 **음수 가중치가 있는 그래프**에서도 최단 경로를 찾을 수 있는 알고리즘입니다. 다만, 음수 사이클이 존재하는 경우, 최단 경로를 찾을 수 없다는 특징이 있습니다.

### 벨만-포드 알고리즘 동작 과정
1. 시작 정점에서 모든 정점까지의 거리를 무한대로 초기화하고, 시작 정점의 거리는 0으로 설정합니다.
2. 모든 간선에 대해 (V - 1)번 반복하여 각 간선의 끝점까지의 거리를 갱신합니다.
3. 추가적으로 한 번 더 모든 간선을 확인하여, 음수 사이클이 있는지 체크합니다.

### 벨만-포드 알고리즘 구현 예제 (C#)

```csharp
using System;

class BellmanFord
{
    class Edge
    {
        public int From;
        public int To;
        public int Weight;
        public Edge(int from, int to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }
    }

    static void Main(string[] args)
    {
        Edge[] edges = new Edge[]
        {
            new Edge(1, 2, 4),
            new Edge(1, 3, 5),
            new Edge(2, 3, -2),
            new Edge(3, 4, 3)
        };

        int[] dist = BellmanFordAlgorithm(edges, 1, 4);

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Distance from 1 to {i}: {dist[i]}");
        }
    }

    static int[] BellmanFordAlgorithm(Edge[] edges, int start, int n)
    {
        int[] dist = new int[n + 1];
        for (int i = 1; i <= n; i++) dist[i] = int.MaxValue;
        dist[start] = 0;

        for (int i = 0; i < n - 1; i++)
        {
            foreach (var edge in edges)
            {
                if (dist[edge.From] != int.MaxValue && dist[edge.From] + edge.Weight < dist[edge.To])
                {
                    dist[edge.To] = dist[edge.From] + edge.Weight;
                }
            }
        }

        foreach (var edge in edges)
        {
            if (dist[edge.From] != int.MaxValue && dist[edge.From] + edge.Weight < dist[edge.To])
            {
                Console.WriteLine("Negative cycle detected!");
                return null;
            }
        }

        return dist;
    }
}
```

### 벨만-포드 알고리즘의 특징
- **시간 복잡도**: O(V * E)
- **장점**: 음수 가중치가 있는 그래프에서도 사용할 수 있으며, 음수 사이클을 감지할 수 있습니다.

---

## 플로이드-워셜 알고리즘

**플로이드-워셜 알고리즘(Floyd-Warshall Algorithm)** 은 **모든 정점 간의 최단 경로를 구하는 알고리즘**입니다. 이 알고리즘은 동적 계획법을 기반으로 하며, 주로 **작은 크기의 그래프**에서 사용됩니다.

### 플로이드-워셜 알고리즘 동작 과정
1. 각 정점에서 다른 정점으로 가는 거리를 행렬로 표현합니다. 처음에는 간선이 없는 경우 무한대로, 자기 자신은 0으로 설정합니다.
2. 중간에 거쳐 가는 정점을 하나씩 추가하며, 각 정점 간의 최단 거리를 갱신합니다.
3. 모든 정점에 대해 이 과정을 반복합니다.

### 플로이드-워셜 알고리즘 구현 예제 (C#)

```csharp
using System;

class FloydWarshall
{
    static void Main(string[] args)
    {
        int INF = int.MaxValue;
        int[,] graph = {
            { 0, 3, INF, INF },
            { 2, 0, INF, INF },
            { INF, 7, 0, 1 },
            { 6, INF, INF, 0 }
        };

        int[,] dist = FloydWarshallAlgorithm(graph, 4);

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (dist[i, j] == INF)
                    Console.Write("INF ");
                else
                    Console.Write($"{dist[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int[,] FloydWarshallAlgorithm(int[,] graph, int n)
    {
        int[,] dist = (int[,])graph.Clone();

        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                                        if (dist[i, k] != int.MaxValue && dist[k, j] != int.MaxValue && dist[i, k] + dist[k, j] < dist[i, j])
                    {
                        dist[i, j] = dist[i, k] + dist[k, j];
                    }
                }
            }
        }

        return dist;
    }
}
```

### 플로이드-워셜 알고리즘의 특징
- **시간 복잡도**: O(V³) (V는 정점의 수)
- **장점**: 모든 정점 쌍 간의 최단 경로를 구할 수 있습니다.
- **단점**: 시간 복잡도가 높아, 대규모 그래프에서는 비효율적일 수 있습니다.

---

## 최단 경로 알고리즘 비교

| 알고리즘         | 사용 조건                | 시간 복잡도       | 특징                                     |
|------------------|--------------------------|-------------------|------------------------------------------|
| 다익스트라 알고리즘 | 가중치가 모두 양수인 경우  | O((V + E)log V)   | 음수 가중치 불가, 우선순위 큐 사용       |
| 벨만-포드 알고리즘 | 음수 가중치가 있는 경우    | O(V * E)          | 음수 사이클 감지 가능                    |
| 플로이드-워셜 알고리즘 | 모든 정점 쌍 간의 경로 계산 | O(V³)             | 모든 정점 쌍 간의 최단 경로 계산 가능    |

---

최단 경로 알고리즘들은 그래프의 특성과 요구사항에 따라 선택해서 사용해야 합니다. 다익스트라는 일반적인 경우에 가장 효율적이지만, 음수 가중치가 있는 경우 벨만-포드 알고리즘을 사용해야 하며, 모든 경로를 동시에 구해야 하는 경우 플로이드-워셜 알고리즘이 적합합니다.
