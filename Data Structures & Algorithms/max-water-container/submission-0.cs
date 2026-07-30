public class Solution {
    public int MaxArea(int[] heights) {
        int LargestValue = 0;
        for(int i =0; i < heights.Count(); i++)
        {
            int Next = i+1;
            while(Next < heights.Count())
            {
                int Value = 0;
                if(heights[Next] <= heights[i])
                {
                    Value = heights[Next] * (Next-i);
                }
                else if(heights[Next] >= heights[i])
                {
                    Value = heights[i] * (Next-i);
                }

                if(Value > LargestValue)
                {
                    LargestValue = Value;
                }
                Next++;
            }
        }
        return LargestValue;
    }
}
