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
    List<List<int>> list = new List<List<int>>();
    public List<int> RightSideView(TreeNode root) {
        dfs(root, 0);
        List<int> res = new List<int>();
        foreach(var l in list)
        {
            res.Add(l[l.Count-1]);
        }
        return res;
    }
    private void dfs(TreeNode root, int depth){
        if(root == null)
        {
            return;
        }

        if(list.Count == depth)
        {
            list.Add(new List<int>());
        }
        list[depth].Add(root.val);
        dfs(root.left, depth+1);
        dfs(root.right, depth+1);
    }
}
