using Problems;

namespace Tests;

public class Task_1_ContainsDuplicateTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ContainsDuplicate(int[] nums, bool expected)
    {
        var res = Task_1_ContainsDuplicate.ContainsDuplicate(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new[] { 1, 2, 3, 1 }, true },
            new object[] { new[] { 1, 2, 3, 4 }, false }
        };
}