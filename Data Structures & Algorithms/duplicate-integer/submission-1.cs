public class Solution {
    public bool hasDuplicate(int[] nums) {
         HashSet<int> hash = new HashSet<int>();

         foreach(int num in nums){
            hash.Add(num);
         }
         if(hash.Count >= nums.Length){
            return false;
         }
         return true;
    }
}
