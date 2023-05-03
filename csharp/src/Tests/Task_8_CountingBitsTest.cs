using Problems;

namespace Tests;

public class Task_8_CountingBitsTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MexProfit(int n, int[] expected)
    {
        var res = Task_8_CountingBits.CountBits(n);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { 2, new int[] { 0,1,1} },
            new object[] { 5,new int[] { 0, 1, 1, 2, 1, 2 } },
        };
}