/*public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(int i=0; i<nums.Length;i++){
               // if(nums[i]> target){
               //     continue;
                //}

                for(int j=i+1;j<nums.Length;j++){
                    
                    if(nums[i]+nums[j] == target){
                        return new int[] { i, j };
                    }
                }
        }
        return new int[] {  };    
        }
} */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target){
                    return new int[]{i,j};
                }
                if((nums[nums.Length-i-1]+nums[nums.Length-j-1]) == target)
                {
                    return new int[]{nums.Length-i-1,nums.Length-j-1};
                }
            }
        }
        return [];
    }
}