public class Solution {
public int[] TwoSum(int[] nums, int target)
{
    HashSet<int> hashSet = new();
    for (int i = 0; i < nums.Length; i++)
    {
        int neededNumber = target - nums[i];
        if (hashSet.Contains(neededNumber))
        {
            return new int[] { Array.IndexOf(nums, neededNumber), i };
        }
        hashSet.Add(nums[i]);
    }
    return null;
}
}
