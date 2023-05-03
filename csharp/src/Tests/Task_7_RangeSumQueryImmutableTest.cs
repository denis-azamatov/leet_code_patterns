using Problems;

namespace Tests;

public class Task_7_RangeSumQueryImmutableTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MexProfit(int[] nums, int left, int right, int expected)
    {
        var numArray = new Task_7_RangeSumQueryImmutable.NumArray(nums);
        var res = numArray.SumRange(left, right);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new int[] {-2,0,3,-5,2,-1}, 0,2,1},
            new object[] { new int[] {-2,0,3,-5,2,-1}, 2,5,-1},
            new object[] { new int[] {-2,0,3,-5,2,-1}, 0,5,-3},
        };
}