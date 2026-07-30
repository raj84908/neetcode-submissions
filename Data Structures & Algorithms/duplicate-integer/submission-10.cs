public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int>numbers = new HashSet<int>();

        foreach(int x in nums)
        {
            numbers.Add(x);
        }

        return !(nums.Length == numbers.Count());
        
    }
}