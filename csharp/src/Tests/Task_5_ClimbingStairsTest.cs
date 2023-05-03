using Problems;

namespace Tests;

public class Task_5_ClimbingStairsTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ClimbingStairs(int n, int expected)
    {
        var res = Task_5_ClimbingStairs.ClimbingStairs(n);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { 2, 2},
            new object[] { 1, 1},
            new object[] { 5, 8}
        };
}