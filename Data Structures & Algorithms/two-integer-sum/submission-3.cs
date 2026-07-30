public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
    Dictionary<int,int>NumberValue = new Dictionary<int,int>();

    for(int i =0; i < nums.Count(); i++) //O(n)
    {
        int ValueNeeded = target - nums[i];
        if(NumberValue.ContainsKey(ValueNeeded)) 
        {
            return new int[] {NumberValue[ValueNeeded], i};
        }
        else
        {
            NumberValue[nums[i]] = i;
        }
    }

    return new int[2];
        

    }

    //Thoughts and reasoning
    //Create a dictionary that iterates through the nums. We create a dict that stores the
    //value and its index. While iterating we check the Dict to see if it contains the value we are looking for
    // if it does then we check which value is smaller and based on that return the order.
}
