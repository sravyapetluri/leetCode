public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        n = n*(n+1)/2;
        int actualSum = 0;
        foreach(int num in nums)
        {
            actualSum +=num;
        }
        return n-actualSum;
    }
}