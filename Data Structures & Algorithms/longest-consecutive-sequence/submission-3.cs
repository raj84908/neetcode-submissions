public class Solution {
    public int LongestConsecutive(int[] nums) {

        int LongestCount =0;
        int TempCount = 1;
        int[] SortedArray = nums.Distinct()
                      .OrderBy(n => n)
                      .ToArray();

        for(int i =0; i < SortedArray.Count(); i++)
        {
            bool next = i+1 < SortedArray.Count() && SortedArray[i]+1 == SortedArray[i+1];

            if(LongestCount < TempCount)
            {
                LongestCount = TempCount;
            }

            if(next)
            {
                TempCount++;
            }
            else{
                TempCount = 1;
            }
            
        }
        return LongestCount;
        
    }
}
