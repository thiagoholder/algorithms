namespace DataStructure;

public class LinkedList
{
    public Node Head { get; private set; }

    public LinkedList()
    {
        Head = null;
    }

    public void Append(int value)
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            return;
        }

        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public void Prepend(int value)
    {
        var newNode = new Node(value);
        newNode.Next = Head;
        Head = newNode;
    }

    public void DeleteWithValue(int value)
    {
        if (Head == null) return;

        if (Head.Value == value)
        {
            Head = Head.Next;
            return;
        }

        Node current = Head;
        while (current.Next != null && current.Next.Value != value)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }
}