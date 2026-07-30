public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int First = 0;
        int Last = numbers.Count()-1;

        while(Last > First)
        {
            int Sum = numbers[First] + numbers[Last];
            if(Sum == target)
            {
                return new int[] {First+1, Last+1};
            }
            else if(Sum > target)
            {
                Last--;
            }
            else{
                First++;
            }
        }
        return new int[2];
    }
}
