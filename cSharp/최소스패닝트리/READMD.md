# 최소 스패닝 트리 (Minimum Spanning Tree, MST)

**최소 스패닝 트리(MST)**는 그래프에서 모든 노드를 연결하는 부분 그래프 중, **간선들의 가중치 합이 최소**가 되는 트리입니다. 이 트리는 원래의 그래프의 모든 노드를 포함하지만 **사이클이 없고, 간선의 수가 최소인 구조**입니다. 스패닝 트리는 주로 **통신 네트워크, 전력망 구축, 도로망 설계**와 같은 문제에서 사용됩니다.

## 최소 스패닝 트리의 성질

- **사이클 없음**: 트리는 사이클을 포함하지 않습니다.
- **최소 비용**: 주어진 그래프에서 선택된 간선들의 가중치 합이 최소입니다.
- **간선 수**: 노드의 개수가 `V`일 때, 최소 스패닝 트리의 간선 수는 `V-1`개입니다.
  
## 최소 스패닝 트리 알고리즘

### 크루스칼 알고리즘 (Kruskal’s Algorithm)

크루스칼 알고리즘은 **간선 중심**의 알고리즘으로, 간선을 가중치 순서대로 정렬한 후, 사이클이 생기지 않도록 선택해나가는 방식입니다. **서로소 집합(Disjoint Set)**을 이용해 사이클 여부를 확인합니다.

#### 크루스칼 알고리즘의 동작 과정
1. 그래프의 모든 간선을 **가중치 오름차순**으로 정렬합니다.
2. 간선을 하나씩 선택하면서, 해당 간선을 추가해도 **사이클이 생기지 않는다면** 트리에 포함시킵니다.
3. 간선의 개수가 `V-1`개가 될 때까지 과정을 반복합니다.

#### C# 예제 코드 (크루스칼 알고리즘)
```csharp
using System;
using System.Collections.Generic;

class Edge : IComparable<Edge>
{
    public int Src, Dest, Weight;

    public Edge(int src, int dest, int weight)
    {
        Src = src;
        Dest = dest;
        Weight = weight;
    }

    public int CompareTo(Edge other)
    {
        return this.Weight.CompareTo(other.Weight);
    }
}

class DisjointSet
{
    private int[] parent, rank;

    public DisjointSet(int n)
    {
        parent = new int[n];
        rank = new int[n];
        for (int i = 0; i < n; i++) parent[i] = i;
    }

    public int Find(int i)
    {
        if (parent[i] != i)
            parent[i] = Find(parent[i]);
        return parent[i];
    }

    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX != rootY)
        {
            if (rank[rootX] < rank[rootY])
                parent[rootX] = rootY;
            else if (rank[rootX] > rank[rootY])
                parent[rootY] = rootX;
            else
            {
                parent[rootY] = rootX;
                rank[rootX]++;
            }
        }
    }
}

class KruskalMST
{
    public List<Edge> Kruskal(List<Edge> edges, int V)
    {
        List<Edge> result = new List<Edge>();
        edges.Sort();

        DisjointSet ds = new DisjointSet(V);

        foreach (var edge in edges)
        {
            int x = ds.Find(edge.Src);
            int y = ds.Find(edge.Dest);

            if (x != y)
            {
                result.Add(edge);
                ds.Union(x, y);
            }

            if (result.Count == V - 1)
                break;
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        int V = 4; // 노드 개수
        List<Edge> edges = new List<Edge>
        {
            new Edge(0, 1, 10),
            new Edge(0, 2, 6),
            new Edge(0, 3, 5),
            new Edge(1, 3, 15),
            new Edge(2, 3, 4)
        };

        KruskalMST mst = new KruskalMST();
        List<Edge> result = mst.Kruskal(edges, V);

        Console.WriteLine("Minimum Spanning Tree:");
        foreach (var edge in result)
        {
            Console.WriteLine($"{edge.Src} -- {edge.Dest} == {edge.Weight}");
        }
    }
}
```

### 프림 알고리즘 (Prim’s Algorithm)

프림 알고리즘은 **노드 중심**의 알고리즘으로, 하나의 노드를 시작점으로 설정하고, 해당 노드에서 **가장 작은 가중치를 가지는 간선**을 선택하여 트리를 확장해 나갑니다.

#### 프림 알고리즘의 동작 과정
1. 임의의 시작 노드를 선택하고, 해당 노드를 MST 집합에 포함시킵니다.
2. MST 집합에 있는 노드와, 그 외의 노드를 연결하는 간선 중에서 **가장 작은 가중치**를 가진 간선을 선택하여 추가합니다.
3. 모든 노드가 MST에 포함될 때까지 이 과정을 반복합니다.

#### C# 예제 코드 (프림 알고리즘)
```csharp
using System;
using System.Collections.Generic;

class PrimMST
{
    private static int V = 5;

    public void Prim(int[,] graph)
    {
        int[] parent = new int[V]; // MST를 구성하는 간선을 저장
        int[] key = new int[V]; // 각 노드에 연결된 최소 간선 가중치를 저장
        bool[] mstSet = new bool[V]; // 노드가 MST에 포함되었는지 여부

        for (int i = 0; i < V; i++)
        {
            key[i] = int.MaxValue; // 가중치 값을 무한대(int.MaxValue)로 초기화
            mstSet[i] = false; // MST에 포함되지 않음
        }

        key[0] = 0; // 시작 노드를 선택
        parent[0] = -1; // 루트 노드

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinKey(key, mstSet); // MST에 포함되지 않은 노드 중 최소 키 값을 가진 노드 선택
            mstSet[u] = true; // 선택된 노드를 MST에 포함

            for (int v = 0; v < V; v++)
            {
                if (graph[u, v] != 0 && mstSet[v] == false && graph[u, v] < key[v])
                {
                    parent[v] = u;
                    key[v] = graph[u, v];
                }
            }
        }

        PrintMST(parent, graph);
    }

    private int MinKey(int[] key, bool[] mstSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!mstSet[v] && key[v] < min)
            {
                min = key[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    private void PrintMST(int[] parent, int[,] graph)
    {
        Console.WriteLine("Edge   Weight");
        for (int i = 1; i < V; i++)
        {
            Console.WriteLine($"{parent[i]} - {i}    {graph[i, parent[i]]}");
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] graph = new int[,]
        {
            { 0, 2, 0, 6, 0 },
            { 2, 0, 3, 8, 5 },
            { 0, 3, 0, 0, 7 },
            { 6, 8, 0, 0, 9 },
            { 0, 5, 7, 9, 0 }
        };

        PrimMST mst = new PrimMST();
        mst.Prim(graph);
    }
}
```

## 최소 스패닝 트리의 활용

- **네트워크 설계**: 통신 네트워크, 전력망 등의 최소 비용 연결을 설계할 때 사용됩니다.
- **도로 설계**: 도시와 도시를 연결하는 최소 비용의 도로망 설계에 사용됩니다.
- **클러스터링**: 데이터 분석에서 군집을 형성하는 데 활용할 수 있습니다.

최소 스패닝 트리는 여러 분야에서 비용 절감을 목적으로 사용하는 중요한 알고리즘입니다.
