namespace DataStructure;

public class BinarySearchTree
{
    public TreeNode Root { get; set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private TreeNode InsertRec(TreeNode root, int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        if (value < root.Value)
            root.Left = InsertRec(root.Left, value);
        else if (value > root.Value)
            root.Right = InsertRec(root.Right, value);

        return root;
    }

    public bool Search(int value)
    {
        return SearchRec(Root, value);
    }

    private bool SearchRec(TreeNode root, int value)
    {
        if (root == null) 
            return false;

        if(root.Value == value)
            return true;

        if(value < root.Value)
            return SearchRec(root.Left, value);

        return SearchRec(root.Right, value);
    }

    public void Delete(int value) 
    { 
        Root = DeleteRec(Root, value);
    }

    private TreeNode DeleteRec(TreeNode root, int value)
    {
        if (root == null) return root;

        if(value < root.Value)
            root.Left = DeleteRec(root.Left, value);
        else if(value > root.Value)
            root.Right = DeleteRec(root.Right, value);
        else
        {
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            root.Value = MinValue(root.Right);
            root.Right = DeleteRec(root.Right, root.Value);
        }
        return root;
    }

    private int MinValue(TreeNode root)
    {
        int minValue = root.Value;
        while (root.Left != null)
        {
            minValue = root.Left.Value;
            root = root.Left;
        }
        
        return minValue;
    }

    public List<int> InOrderTraversal()
    {
        List<int> result = new List<int>();
        InOrderRec(Root, result);
        return result;
    }

    private void InOrderRec(TreeNode root, List<int> result)
    {
        if(root != null)
        {
            InOrderRec(root.Left, result);
            result.Add(root.Value);
            InOrderRec(root.Right, result);
        }
    }
}