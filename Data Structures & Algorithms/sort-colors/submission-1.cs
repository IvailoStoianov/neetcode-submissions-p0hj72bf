public class Solution {
    public void SortColors(int[] nums) {
        int[] count = {0,0,0};
        for(int i = 0;i<nums.Count(); i++)
        {
            count[nums[i]]++;
        }

        int n = 0;
        for(int i = 0;  i<count.Count(); i++)
        {
            for(int j = 0; j<count[i]; j++)
            {
                nums[n] = i;
                n++;
            }
        }
    }
}