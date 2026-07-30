public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> FinalList = new List<List<int>>();
        int Last = 0;
        int Middle = 0;
        int Target = 0;
        Array.Sort(nums);

        for(int i =0; i < nums.Count(); i++)
        {
            if(nums[i] > 0) break;

            if(i > 0 && nums[i] == nums[i-1]) continue;

            Last = nums.Count() - 1;
            Middle = i+ 1;
            while(Middle < Last)
            {
                int Sum = nums[i] + nums[Middle] + nums[Last];
                if(Sum == Target)
                {
                    List<int> numbers = new List<int>();
                    numbers.Add(nums[i]);
                    numbers.Add(nums[Middle]);
                    numbers.Add(nums[Last]);
                    FinalList.Add(numbers);
                    Middle++;
                    Last--;

                    while(Middle < Last && nums[Middle] == nums[Middle-1])
                    {
                        Middle++;
                    }

                }
                else if(Sum > Target)
                {
                    Last--;
                }
                else{
                    Middle++;
                }
            }
        }

        return FinalList;
        
    }
}
