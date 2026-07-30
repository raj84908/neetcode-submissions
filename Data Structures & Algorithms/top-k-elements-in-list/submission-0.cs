public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> NumberCount = new Dictionary<int,int>();
        foreach(int x in nums)
        {
            if(!NumberCount.ContainsKey(x))
            {
                NumberCount[x] = 1;
            }
            else
            {
                NumberCount[x]++;
            }
        }

        int [] ValueArray = NumberCount.OrderByDescending(pair=> pair.Value).Select(pair => pair.Key).Take(k).ToArray();
        return ValueArray;


        
    }
}
