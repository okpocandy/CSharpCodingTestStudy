# 트리(Tree) 자료구조

**트리(Tree)**는 계층적 구조를 가진 **비선형** 자료구조로, **노드(Node)**와 **간선(Edge)**으로 구성됩니다. 트리는 하나의 루트(Root)에서 출발하여 여러 노드로 연결되며, 각 노드는 자식 노드를 가질 수 있습니다. 트리는 파일 시스템, 데이터베이스 인덱싱, 경로 탐색 등 다양한 분야에서 활용됩니다.

## 1. 트리의 기본 개념

- **루트 노드(Root Node)**: 트리의 최상단에 위치한 노드입니다.
- **부모 노드(Parent Node)**: 자식 노드를 가지는 노드입니다.
- **자식 노드(Child Node)**: 부모 노드에 연결된 하위 노드입니다.
- **리프 노드(Leaf Node)**: 자식 노드가 없는 노드로, 트리의 말단에 위치합니다.
- **깊이(Depth)**: 루트 노드에서 특정 노드까지의 경로 길이입니다.
- **높이(Height)**: 리프 노드에서 루트 노드까지의 최대 경로 길이입니다.
- **서브트리(Subtree)**: 트리 내에서 특정 노드를 루트로 하는 하위 트리입니다.

## 2. 트리의 종류

### 2.1. 이진 트리 (Binary Tree)
**이진 트리**는 각 노드가 최대 두 개의 자식 노드를 가지는 트리입니다. 자식 노드는 **왼쪽 자식**과 **오른쪽 자식**으로 나뉩니다.

### 2.2. 이진 탐색 트리 (Binary Search Tree)
**이진 탐색 트리(BST)**는 왼쪽 자식 노드의 값이 부모보다 작고, 오른쪽 자식 노드의 값이 부모보다 큰 특징을 가진 이진 트리입니다. 효율적인 탐색, 삽입, 삭제가 가능하여 많이 사용됩니다.

#### C# 예제 (이진 탐색 트리)
```csharp
using System;

class Node
{
    public int Value;
    public Node Left, Right;

    public Node(int value)
    {
        Value = value;
        Left = Right = null;
    }
}

class BinarySearchTree
{
    public Node Root;

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value)
    {
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

        if (value < root.Value)
        {
            root.Left = InsertRec(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = InsertRec(root.Right, value);
        }

        return root;
    }

    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Value + " ");
            InOrder(root.Right);
        }
    }
}

class Program
{
    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(70);
        bst.Insert(60);
        bst.Insert(80);

        bst.InOrder(bst.Root); // 출력: 20 30 40 50 60 70 80
    }
}
```

### 2.3. AVL 트리
**AVL 트리**는 자가 균형 이진 탐색 트리로, 삽입과 삭제 후에도 **균형**을 유지합니다. 각 노드의 왼쪽과 오른쪽 서브트리 높이 차이가 1 이하로 유지됩니다.

### 2.4. 힙 (Heap)
**힙**은 완전 이진 트리의 일종으로, 각 부모 노드가 자식 노드보다 큰(최대 힙) 또는 작은(최소 힙) 특성을 가집니다. 주로 **우선순위 큐**에서 사용됩니다.

#### C# 예제 (최소 힙)
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 최소 힙을 구현하기 위해 C#의 PriorityQueue 사용
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        minHeap.Enqueue(3, 3);
        minHeap.Enqueue(1, 1);
        minHeap.Enqueue(2, 2);

        while (minHeap.Count > 0)
        {
            Console.WriteLine(minHeap.Dequeue()); // 출력: 1 2 3
        }
    }
}
```

## 3. 트리 순회 (Tree Traversal)

트리 순회는 트리의 모든 노드를 특정 순서대로 방문하는 방식입니다.

### 3.1. 전위 순회 (Pre-order Traversal)
루트 노드를 먼저 방문한 후, 왼쪽 서브트리와 오른쪽 서브트리를 차례대로 방문합니다.

```csharp
public void PreOrder(Node root)
{
    if (root != null)
    {
        Console.Write(root.Value + " ");
        PreOrder(root.Left);
        PreOrder(root.Right);
    }
}
```

### 3.2. 중위 순회 (In-order Traversal)
왼쪽 서브트리를 먼저 방문한 후, 루트 노드를 방문하고, 마지막으로 오른쪽 서브트리를 방문합니다. **이진 탐색 트리**의 중위 순회는 값을 **오름차순**으로 출력합니다.

```csharp
public void InOrder(Node root)
{
    if (root != null)
    {
        InOrder(root.Left);
        Console.Write(root.Value + " ");
        InOrder(root.Right);
    }
}
```

### 3.3. 후위 순회 (Post-order Traversal)
왼쪽 서브트리와 오른쪽 서브트리를 먼저 방문한 후, 마지막에 루트 노드를 방문합니다.

```csharp
public void PostOrder(Node root)
{
    if (root != null)
    {
        PostOrder(root.Left);
        PostOrder(root.Right);
        Console.Write(root.Value + " ");
    }
}
```

### 3.4. 레벨 순회 (Level-order Traversal)
각 레벨별로 트리를 순회합니다. **BFS** 방식으로 구현됩니다.

```csharp
using System.Collections.Generic;

public void LevelOrder(Node root)
{
    if (root == null) return;

    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        Node tempNode = queue.Dequeue();
        Console.Write(tempNode.Value + " ");

        if (tempNode.Left != null)
            queue.Enqueue(tempNode.Left);

        if (tempNode.Right != null)
            queue.Enqueue(tempNode.Right);
    }
}
```

## 4. 트리의 응용

- **파일 시스템**: 트리는 파일과 디렉토리의 계층 구조를 표현하는 데 사용됩니다.
- **데이터베이스 인덱스**: B-트리와 같은 트리 구조는 데이터베이스 인덱스에서 빠른 탐색을 가능하게 합니다.
- **자동 완성**: 트라이(Trie) 트리는 문자열을 저장하고 검색하는 데 매우 유용하며, 주로 자동 완성 기능에 사용됩니다.

트리는 다양한 자료구조와 알고리즘에서 필수적인 역할을 하며, 계층적 데이터를 다루는 모든 곳에서 활용됩니다.
