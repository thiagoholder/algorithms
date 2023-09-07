namespace LinkedList;

public static class LinkedListCycleDetector
{
    public static bool HasCycle(Node head)
    {
        if (head == null) return false;

        Node tortoise = head;
        Node hare = head;

        while (hare != null && hare.Next != null)
        {
            tortoise = tortoise.Next;
            hare = hare.Next.Next;

            if (tortoise == hare) return true;
        }

        return false;
    }
}