public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        var leftDepth = GetDepth(root.left);
        var rightDepth = GetDepth(root.right);
        var balanceFactor = leftDepth - rightDepth;
        return (balanceFactor == 1 
            || balanceFactor == -1 
            || balanceFactor == 0)
            && IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    private int GetDepth(TreeNode node)
    {
        if (node == null) return 0;
        var leftDepth = GetDepth(node.left) + 1;
        var rightDepth = GetDepth(node.right) + 1;
        return (leftDepth > rightDepth) ? leftDepth : rightDepth;
    }
}