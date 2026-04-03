public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (map.ContainsKey(num))
        {
            map[num]++;
        }
        else
        {
            map.Add(num, 1);
        }
    }

    int[] result = map.OrderByDescending(x => x.Value)
        .Select(x => x.Key)
        .Take(k)
        .ToArray();
    return result;
}
}
