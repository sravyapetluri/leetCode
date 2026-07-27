public class Solution {
        public IList<string> SummaryRanges(int[] nums) {
        var ranges = new List<string>();
        if (nums == null || nums.Length == 0) {
            return ranges;
        }

        int start = nums[0];

        for (int i = 1; i <= nums.Length; i++) {
            if (i == nums.Length || nums[i] != nums[i - 1] + 1) {
                int end = nums[i - 1];
                if (start == end) {
                    ranges.Add(start.ToString());
                } else {
                    ranges.Add($"{start}->{end}");
                }
                    if (i < nums.Length) 
                {
                            start = nums[i];
                }
            }
        }

        return ranges;
    }
}