public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dups = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(!dups.Add(nums[i])){
               return true;
            }
        }
        return false;
    }
}