using QueueStacks;

namespace QueueTests
{
    public class MyQueueTests
    {
        public MyQueueTests()
        {
            MyQueue<int>.Reset();
        }

        [Fact]
        public void EnqueueAndPeekTest()
        {
            MyQueue<int>.Enqueue(1);
            MyQueue<int>.Enqueue(2);
            MyQueue<int>.Enqueue(3);

            Assert.Equal(1, MyQueue<int>.Peek());
        }

        [Fact]
        public void EnqueueAndDequeueTest()
        {
            MyQueue<int>.Enqueue(1);
            MyQueue<int>.Enqueue(2);
            MyQueue<int>.Enqueue(3);

            Assert.Equal(1, MyQueue<int>.Dequeue());
            Assert.Equal(2, MyQueue<int>.Dequeue());
        }

        [Fact]
        public void DequeueEmptyQueueTest()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() => MyQueue<int>.Dequeue());
            Assert.Equal("Stack empty.", ex.Message);
        }

        [Fact]
        public void PeekEmptyQueueTest()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() => MyQueue<int>.Peek());
            Assert.Equal("Stack empty.", ex.Message);
        }

        [Fact]
        public void MixedOperationsTest()
        {
            MyQueue<int>.Enqueue(1);
            MyQueue<int>.Enqueue(2);

            Assert.Equal(1, MyQueue<int>.Peek());

            MyQueue<int>.Enqueue(3);
            Assert.Equal(1, MyQueue<int>.Dequeue());

            MyQueue<int>.Enqueue(4);
            Assert.Equal(2, MyQueue<int>.Peek());
        }
    }
}