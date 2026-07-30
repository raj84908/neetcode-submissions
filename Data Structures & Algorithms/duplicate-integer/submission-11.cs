public class Solution {
    public bool hasDuplicate(int[] nums) {
        
    HashSet<int>HashNumbers = new HashSet<int>(nums);

    return nums.Count() != HashNumbers.Count(); 


    }
}