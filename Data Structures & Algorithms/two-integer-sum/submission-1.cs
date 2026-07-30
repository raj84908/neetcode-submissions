public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
    Dictionary<int,int>NumberValue = new Dictionary<int,int>();

    for(int i =0; i < nums.Count(); i++)
    {
        int ValueNeeded = target - nums[i]; // 7 - 3 = 4
        if(NumberValue.ContainsKey(ValueNeeded)) // contains 4
        {
            return i > NumberValue[ValueNeeded] ? new int[]{NumberValue[ValueNeeded], i} :  new int[]{i, NumberValue[ValueNeeded]};
        }
        else
        {
            NumberValue[nums[i]] = i;
        }
    }

    return new int[2];
        

    }
}
