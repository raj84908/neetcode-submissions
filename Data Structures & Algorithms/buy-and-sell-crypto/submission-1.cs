public class Solution {
    public int MaxProfit(int[] prices) {

//Come Back and make better
        int Profit = 0;  
        for(int i =0; i < prices.Count(); i++)
        {
            int Buy = prices[i];
            for(int j = i; j < prices.Count(); j++)
            {
                int Sell = prices[j];
                int PotentialProfit = Sell - Buy;
                if(PotentialProfit > Profit)
                {
                    Profit = PotentialProfit;
                }
            }
        }

        return Profit;

    }
}
