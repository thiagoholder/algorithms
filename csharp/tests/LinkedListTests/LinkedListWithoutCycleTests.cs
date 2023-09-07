using DataStructure;

namespace LinkedListTests;

public class LinkedListWithoutCycleTests
{
    [Fact]
    public void EmptyLinkedList_ReturnFalse()
    {
        var result = LinkedListCycleDetector.HasCycle(null);

        Assert.False(result);
    }

    [Fact]
    public void LinkedListWithoutCycle_ReturnsFalse()
    {
        // Arrange
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);

        node1.Next = node2;
        node2.Next = node3;

        // Act
        var result = LinkedListCycleDetector.HasCycle(node1);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void LinkedListWithoutCycle_ReturnsTrue() { 
        
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node2;

        var result = LinkedListCycleDetector.HasCycle(node1);

        Assert.True(result);
    }

    [Fact]
    public void LinkedListWithSingleElementNoCycle_ReturnFalse()
    {
        var node1 = new Node(1);

        var result = LinkedListCycleDetector.HasCycle(node1);

        Assert.False(result);
    }

    [Fact]
    public void LinkedListWithSingleElementNoCycle_ReturnTrue()
    {
        var node1 = new Node(1);
        node1.Next = node1;

        var result = LinkedListCycleDetector.HasCycle(node1);
        Assert.True(result);
    }
}