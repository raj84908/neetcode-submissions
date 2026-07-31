public class Solution {
    public int Trap(int[] height)
    {
        if (height == null || height.Length == 0) {
            return 0;
        }
        int TotalSpace = 0;

        for(int i =0; i < height.Count(); i++)
        {
            int LeftMax = height[i];
            int RightMax = height[i];

            for(int j = 0; j < i; j++)
            {
                LeftMax = Math.Max(LeftMax, height[j]);
            }
            for(int k = i+1; k < height.Count(); k++)
            {
                RightMax = Math.Max(RightMax,height[k]);
            }

            TotalSpace += Math.Min(LeftMax,RightMax) - height[i];
        }

        return TotalSpace;

    }


}
