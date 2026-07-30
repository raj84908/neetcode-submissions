public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int [] arr = new int [nums.Count()];
        int multiply = 1;
        int zeroCount = 0;

        for(int i =0; i < nums.Count(); i ++)
        {
            if(nums[i] == 0)
            {
                zeroCount++;
            }
            else{
                multiply = multiply * nums[i];
            }
            
        }
        
        for(int j = 0; j < nums.Count(); j++)
        {
            if(zeroCount >= 2)
            {
                return arr;
            }
            else if(zeroCount == 1 && nums[j] == 0)
            {
                int [] arr2 = new int [nums.Count()];
                arr2[j] = multiply;
                return arr2;
            }
            else{
                arr[j] = multiply / nums[j];
            }
            
        }

        return arr;





    }
}
