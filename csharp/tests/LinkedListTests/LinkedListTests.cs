using DataStructure;

namespace LinkedListTests;

public class LinkedListTests
{
    [Fact]
    public void Append_AddsElementToEndOfList()
    {
        var list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.Append(3);

        Assert.Equal(1, list.Head.Value);
        Assert.Equal(2, list.Head.Next.Value);
        Assert.Equal(3, list.Head.Next.Next.Value);
    }

    [Fact]
    public void Prepend_AddsElementToStartOfList()
    {
        var list = new LinkedList();
        list.Append(2);
        list.Append(3);
        list.Prepend(1);

        Assert.Equal(1, list.Head.Value);
        Assert.Equal(2, list.Head.Next.Value);
        Assert.Equal(3, list.Head.Next.Next.Value);
    }

    [Fact]
    public void DeleteWithValue_DeletesElementFromList()
    {
        var list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        list.DeleteWithValue(2);

        Assert.Equal(1, list.Head.Value);
        Assert.Equal(3, list.Head.Next.Value);
        Assert.Null(list.Head.Next.Next);
    }

    [Fact]
    public void DeleteWithValue_DeletesHeadWhenValueMatches()
    {
        var list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.DeleteWithValue(1);

        Assert.Equal(2, list.Head.Value);
        Assert.Null(list.Head.Next);
    }
    [Fact]
    public void DeleteWithValue_DoesNothingWhenValueNotFound()
    {
        var list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.DeleteWithValue(3);

        Assert.Equal(1, list.Head.Value);
        Assert.Equal(2, list.Head.Next.Value);
    }
}