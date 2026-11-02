public class Solution {
    public int MaxProfit(int[] prices)
{
    int minPrice = prices[0];   // cheapest price seen so far
    int maxProfit = 0;          // 0 because "no trade" is allowed

    for (int i = 1; i < prices.Length; i++)
    {
        int profit = prices[i] - minPrice;               // step 1: sell today
        maxProfit = Math.Max(maxProfit, profit);          // step 2: keep the best profit
        minPrice = prices[i] < minPrice ? prices[i] : minPrice;  // step 3: update the cheapest price
    }
    return maxProfit;
}
}
