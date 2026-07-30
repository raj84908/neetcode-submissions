public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> ValueIndex = new Dictionary<int,int>();

        for(int x =0; x < nums.Length; x++)
        {
            int remaining = target - nums[x];
            if(ValueIndex.ContainsKey(remaining))
            {
                return new int [] {ValueIndex[remaining], x};
            }
            else
            {
                ValueIndex.Add(nums[x],x);
            }
        }

        return new int [] {};



    }
}
