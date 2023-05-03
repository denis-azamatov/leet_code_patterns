using Problems;

namespace Tests;

public class Task_4_SingleNumberTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void SingleNumber(int[] nums, int expected)
    {
        var res = Task_4_SingleNumber.SingleNumber(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new[] { 2,2,1 }, 1},
            new object[] { new[] { 4, 1, 2, 1, 2 }, 4},
            new object[] { new[] { 1 }, 1}
        };
}