public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] answer = new int[nums.Length * 2];
        int pointerAnswer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[pointerAnswer] = nums[i];
            pointerAnswer++;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            answer[pointerAnswer] = nums[i];
            pointerAnswer++;
        }
        return answer;
    }
}