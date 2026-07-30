public class Solution {
    public bool hasDuplicate(int[] nums) {
        
    List<int>numbers = new List<int>(nums);
    
    return numbers.Count() != numbers.Distinct().Count();


    }
}