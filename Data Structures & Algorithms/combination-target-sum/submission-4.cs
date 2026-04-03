public class Solution {
    public List<List<int>> CombinationSum(int[] candidates, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> subset = new List<int>();
        Dfs(candidates, 0, target, result, subset);
        return result;
    }

    private void Dfs(int[] nums, int index, int target, List<List<int>> res, List<int> subset) {
        if (target == 0) {
            res.Add(new List<int>(subset));
            return;
        }

        if (target < 0 || index == nums.Length) {
            return;
        }

        // include nums[index]
        subset.Add(nums[index]);
        Dfs(nums, index, target - nums[index], res, subset); // reuse same number
        subset.RemoveAt(subset.Count - 1);

        // skip nums[index]
        Dfs(nums, index + 1, target, res, subset);
    }
}
