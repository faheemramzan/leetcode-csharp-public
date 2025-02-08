namespace TestProject.Tree.InvertTree;
/// <summary>
/// https://leetcode.com/problems/invert-binary-tree/
/// </summary>
public partial class InvertTreeSolution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;
            
        (root.left, root.right) = (root.right, root.left);

        this.InvertTree(root.left);
        this.InvertTree(root.right);

        return root;
    }
}