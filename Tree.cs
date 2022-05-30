namespace TreeTest;

public class Tree<T>
{
    public Tree(Node<T> root)
    {
        this.Root = root;
    }

    public Node<T> Root { get; set; }

    public List<T> BFS(Node<T> root)
    {
        Queue<Node<T>> queue = new Queue<Node<T>>();
        List<T> nodeList = new List<T>();

        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            Node<T> current = queue.Dequeue();
            nodeList.Add(current.Value);
            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }

        return nodeList;
    }

    public void DFS(Node<T> root, int spaces)
    {
        Console.Write(new String(' ', spaces));
        Console.WriteLine(root);

        foreach (var child in root.Children)
        {
            DFS(child, spaces + 3);
        }
    }

    public void DFS(Node<T> root)
    {
        Stack<Node<T>> stack = new Stack<Node<T>>();

        stack.Push(root);
        while (stack.Count > 0)
        {
            Node<T> current = stack.Pop();
            Console.Write(current.Value+" ");
            foreach (var child in current.Children)
            {
                stack.Push(child);
            }
        }
    }
}