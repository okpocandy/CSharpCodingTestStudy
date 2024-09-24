using System;
using System.Collections.Generic;

class Node
{
    public char Value;
    public Node Left, Right;

    public Node(char value)
    {
        Value = value;
        Left = Right = null;
    }
}

class BinaryTree
{
    public Dictionary<char, Node> nodes = new Dictionary<char, Node>();

    public void AddNode(char root, char left, char right)
    {
        if (!nodes.ContainsKey(root))
            nodes[root] = new Node(root);

        if (left != '.')
        {
            nodes[left] = new Node(left);
            nodes[root].Left = nodes[left];
        }

        if (right != '.')
        {
            nodes[right] = new Node(right);
            nodes[root].Right = nodes[right];
        }
    }

    // 전위 순회: (루트) (왼쪽 자식) (오른쪽 자식)
    public void PreOrder(Node node)
    {
        if (node == null) return;
        Console.Write(node.Value);
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 중위 순회: (왼쪽 자식) (루트) (오른쪽 자식)
    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Value);
        InOrder(node.Right);
    }

    // 후위 순회: (왼쪽 자식) (오른쪽 자식) (루트)
    public void PostOrder(Node node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Value);
    }
}

class Program
{
    static void Main()
    {
        // 입력 처리
        int n = int.Parse(Console.ReadLine());
        BinaryTree tree = new BinaryTree();

        // 트리 구성
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            char root = input[0][0];
            char left = input[1][0];
            char right = input[2][0];

            tree.AddNode(root, left, right);
        }

        // 전위 순회 출력
        tree.PreOrder(tree.nodes['A']);
        Console.WriteLine();

        // 중위 순회 출력
        tree.InOrder(tree.nodes['A']);
        Console.WriteLine();

        // 후위 순회 출력
        tree.PostOrder(tree.nodes['A']);
        Console.WriteLine();
    }
}
