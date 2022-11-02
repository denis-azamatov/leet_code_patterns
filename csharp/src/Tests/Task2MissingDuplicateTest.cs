using Problems;

namespace Tests;

public class Task2MissingDuplicateTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MissingNumber(int[] nums, int expected)
    {
        var res = new Task2MissingNumber().MissingNumber(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new[] { 3, 0, 1 }, 2 },
            new object[] { new[] { 0, 1 }, 2 },
            new object[] { new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8 },
        };
}