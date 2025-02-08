namespace TestProject.Tree.InvertTree;

/// <summary>
/// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
/// </summary>
public partial class LowestCommonAncestorSolution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var curr = root;
        while (curr != null)
        {
            if (p.val < curr.val && q.val < curr.val)
            {
                curr = curr.left;
            }
            else if (p.val > curr.val && q.val > curr.val)
            {
                curr = curr.right;
            }
            else
            {
                return curr;
            }
        }

        return curr;
    }
}