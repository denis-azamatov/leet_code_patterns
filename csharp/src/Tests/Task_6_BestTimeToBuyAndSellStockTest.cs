using Problems;

namespace Tests;

public class Task_6_BestTimeToBuyAndSellStockTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MexProfit(int[] prices, int expected)
    {
        var res = Task_6_BestTimeToBuyAndSellStock.MaxProfit(prices);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new int[] {7,1,5,3,6,4}, 5},
            new object[] { new int[] { 7, 6, 4, 3, 1 }, 0},
        };
}