/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> output = new List<List<int>>();
    public List<List<int>> LevelOrder(TreeNode root) {
        dfs(root, 0);
        return output;
    }
    private void dfs(TreeNode root, int depth)
    {
        if(root == null)
        {
            return;
        }

        if(output.Count == depth)
        {
            output.Add(new List<int>()); 
        }

        output[depth].Add(root.val);
        dfs(root.left,depth+1);
        dfs(root.right,depth+1);
    }
}
