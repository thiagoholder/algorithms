namespace QueueStacks
{
    public class MyQueue<T>
    {
        private static Stack<T> stackNewestOnTop = new Stack<T>();
        private static Stack<T> stackOldestOnTop = new Stack<T>();

        public static void Enqueue(T value)
        {
            stackNewestOnTop.Push(value);
        }

        public static T Peek()
        {
            ShiftStacks();
            return stackOldestOnTop.Peek();
        }

        public static T Dequeue()
        {
            ShiftStacks();
            return stackOldestOnTop.Pop();
        }

        private static void ShiftStacks()
        {
            if (stackOldestOnTop.Count == 0)
            {
                while (stackNewestOnTop.Count > 0)
                {
                    stackOldestOnTop.Push(stackNewestOnTop.Pop());
                }
            }
        }

        public static void Reset()
        {
            stackNewestOnTop.Clear();
            stackOldestOnTop.Clear();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Enqueue some values
            MyQueue<int>.Enqueue(1);
            MyQueue<int>.Enqueue(2);
            MyQueue<int>.Enqueue(3);
            MyQueue<int>.Enqueue(4);

            // Peek the front of the queue
            Console.WriteLine("Peek: " + MyQueue<int>.Peek());  // Outputs 1

            // Dequeue values
            Console.WriteLine("Dequeue: " + MyQueue<int>.Dequeue());  // Outputs 1
            Console.WriteLine("Dequeue: " + MyQueue<int>.Dequeue());  // Outputs 2

            // Enqueue more values
            MyQueue<int>.Enqueue(5);
            MyQueue<int>.Enqueue(6);

            // Peek again
            Console.WriteLine("Peek: " + MyQueue<int>.Peek());  // Outputs 3

            // Dequeue the rest of the values
            Console.WriteLine("Dequeue: " + MyQueue<int>.Dequeue());  // Outputs 3
            Console.WriteLine("Dequeue: " + MyQueue<int>.Dequeue());  // Outputs 4
            Console.WriteLine("Dequeue: " + MyQueue<int>.Dequeue());  // Outputs 5
            Console.WriteLine("Dequeue: " + MyQueue<int>.Dequeue());  // Outputs 6
        }
    }
}