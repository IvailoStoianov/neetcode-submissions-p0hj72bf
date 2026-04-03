public class Solution {
    List<int> res = new List<int>();
    
    public List<int> RightSideView(TreeNode root) {
        dfs(root, 0);
        return res;
    }
    
    private void dfs(TreeNode node, int depth) {
        if (node == null) {
            return;
        }
        
        if (res.Count == depth) {
            res.Add(node.val);
        }
        
        dfs(node.right, depth + 1);
        dfs(node.left, depth + 1);
    }
}