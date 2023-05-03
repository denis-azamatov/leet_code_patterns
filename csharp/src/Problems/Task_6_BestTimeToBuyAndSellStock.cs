using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Problems
{
    /// <summary>
    /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
    /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock. 
    /// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    /// </summary>
    public static class Task_6_BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
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
    }
}
