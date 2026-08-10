public class Solution {
    public void MoveZeroes(int[] nums) {
        int temp =0;
        for(int i=0;i<nums.Length;i++)
        {
           if(nums[i] !=0)
           {
                nums[temp] = nums[i];
                temp++;
           }
           
        }
        while(temp<nums.Length)
           {
            nums[temp] =0;
            temp++;
           }
    }
}