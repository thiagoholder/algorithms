namespace DataStructure.Tests;

public class BinarySearchTreeTests
{
    [Fact]
    public void Insert_SingleValue_RootIsSet()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);

        Assert.NotNull(bst.Root);
        Assert.Equal(5, bst.Root.Value);
    }

    [Fact]
    public void Search_ValueExists_ReturnTrue()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);

        bool exists = bst.Search(7);

        Assert.True(exists);
    }

    [Fact]
    public void Search_ValueDoesNotExists_ReturnFalse()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);

        bool exists = bst.Search(10);

        Assert.False(exists);
    }

    [Fact]
    public void Delete_LeafNode_NodeIsRemoved()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Delete(3);

        bool exists = bst.Search(3);

        Assert.False(exists);
    }

    [Fact]
    public void Delete_NodeWithOneChild_NodeIsRemoved()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(8);
        bst.Delete(7);

        bool exists = bst.Search(7);

        Assert.False(exists);
        Assert.True(bst.Search(8));
    }

    [Fact]
    public void Delete_NodeWithTwoChildren_NodeIsRemoved()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(6);
        bst.Insert(8);
        bst.Delete(7);

        bool exists = bst.Search(7);

        Assert.False(exists);
        Assert.True(bst.Search(6));
        Assert.True(bst.Search(8));
    }

    [Fact]
    public void InOrderTraversal_ValuesInOrder_ReturnsCorrectOrder()
    {
        var bst = new BinarySearchTree();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(1);
        bst.Insert(4);
        bst.Insert(6);
        bst.Insert(8);

        List<int> result = bst.InOrderTraversal();

        Assert.Equal(new List<int> { 1, 3, 4, 5, 6, 7, 8 }, result);
    }
}