class Node<T>
{
    public T Data;
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(10);
        Node<int> Node2 = new Node<int>(9999);
        Node<int> Node3 = new Node<int>(3034);
        Node<int> Node4 = new Node<int>(49543);

        Node1.Next = Node2;
        Node2.Next = Node3;
        Node3.Next = Node4;


        Node2.Prev = Node1;
        Node3.Prev = Node1;
        Node4.Prev = Node3;

        Node<int> CurNode = Node1;
        while(null != CurNode)
        {
            Console.WriteLine(CurNode.Data);
            CurNode = CurNode.Next;
        }

        Node<int> RCurNode = Node4;

        while (null != RCurNode)
        {
            Console.WriteLine(RCurNode.Data);
            RCurNode = RCurNode.Prev;
        }

    }
}
