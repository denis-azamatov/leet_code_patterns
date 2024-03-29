﻿namespace Tests;

/// <summary>
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock. 
/// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
/// </summary>
public class Task_6_BestTimeToBuyAndSellStock
{
    public static int Run(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = int.MaxValue;

        foreach (int price in prices)
        {
            if (price < minPrice)
                minPrice = price;
            else if (price - minPrice > maxProfit)
                maxProfit = price - minPrice;
        }

        return maxProfit;
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int expected, int[] prices)
    {
        var res = Run(prices);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] {5, new int[] {7,1,5,3,6,4}},
            new object[] {0, new int[] { 7, 6, 4, 3, 1 }},
        };
}